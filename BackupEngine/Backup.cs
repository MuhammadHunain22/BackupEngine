﻿using BackupEngine.Data;
using System.Data;
using System.IO.Compression;

namespace BackupEngine
{
    public partial class Backup : Form
    {
        private readonly DBContext context;
        private readonly Home _home;

        public Backup(Home home)
        {
            context = new DBContext();
            _home = home;
            InitializeComponent();
            StartBackup();
        }

        private async void StartBackup()
        {
            int totalProjectToBackup = 0;
            int ProjectBackuped = 0;
            try
            {
                Logger.Log("Starting Backup", BackupLogList, LogType.Backup);
                DataTable projects = await Task.Run(() => context.GetWhere("Projects", "IsBackup=1", "*"));
                Logger.Log($"{projects.Rows.Count} Projects Found To Backup", BackupLogList, LogType.Backup);

                if (projects.Rows.Count == 0)
                {
                    return;
                }

                List<DataRow> projectList = await Task.Run(() => projects.AsEnumerable().ToList());

                ParallelOptions parallelOptions = new()
                {
                    MaxDegreeOfParallelism = 5
                };

                int i = 0;
                totalProjectToBackup = projects.Rows.Count;
                await Parallel.ForEachAsync(projectList, parallelOptions, async (project, token) =>
                {
                    bool IsSuccessful = false;
                    try
                    {
                        i++;
                        Logger.Log($"Started Backup Of {project?.ItemArray[1]?.ToString()}", BackupLogList, LogType.Backup);
                        if (!await Task.Run(() => Directory.Exists($@"{project?.ItemArray[2]?.ToString()}")))
                        {
                            Logger.Log($@"No Project Directory Found on {project?.ItemArray[2]?.ToString()}", BackupLogList, LogType.Backup);
                            return;
                        }

                        if (File.Exists(Path.Combine($@"{project?.ItemArray[3]?.ToString()}", $@"{project?.ItemArray[1]?.ToString()}\{DateTime.UtcNow.ToString("dd-MM-yyyy")}-{project?.ItemArray[1]?.ToString()}.zip")))
                        {
                            Logger.Log($"Backup Already Exist Of {project?.ItemArray[1]?.ToString()}", BackupLogList, LogType.Backup);
                            return;
                        }

                        Logger.Log($@"Project {project?.ItemArray[1]?.ToString()} found on {project?.ItemArray[2]?.ToString()}", BackupLogList, LogType.Backup);

                        if (!await Task.Run(() => Directory.Exists(Path.Combine($@"{project?.ItemArray[3]?.ToString()}", $@"{project?.ItemArray[1]?.ToString()}"))))
                        {
                            Logger.Log($"Creating Backup Directory Of {project?.ItemArray[1]?.ToString()}", BackupLogList, LogType.Backup);
                            await Task.Run(() => Directory.CreateDirectory(Path.Combine($@"{project?.ItemArray[3]?.ToString()}", $@"{project?.ItemArray[1]?.ToString()}")));
                        }

                        Logger.Log($"Start Ziping Of {project?.ItemArray[1]?.ToString()}", BackupLogList, LogType.Backup);
                        await Task.Run(() => ZipFile.CreateFromDirectory($@"{project?.ItemArray[2]?.ToString()}", Path.Combine($@"{project?.ItemArray[3]?.ToString()}", $@"{project?.ItemArray[1]?.ToString()}\{DateTime.UtcNow.ToString("dd-MM-yyyy")}-{project?.ItemArray[1]?.ToString()}.zip")));
                        IsSuccessful = true;
                        await Task.Run(() => UpdateProgress(i, projectList.Count));
                        Logger.Log($"Ziping Complete Of {project?.ItemArray[1]?.ToString()}", BackupLogList, LogType.Backup);
                        Logger.Log($"Backup Done Of {project?.ItemArray[1]?.ToString()}", BackupLogList, LogType.Backup);
                        ProjectBackuped++;
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        Logger.Log($"{ex.Message} Please Give Permissions to Access The Folder", ExpLogBackup, LogType.BackupException);

                    }
                    catch (Exception ex)
                    {
                        _ = ex.Message;
                        Logger.Log(ex.Message, ExpLogBackup, LogType.BackupException);
                    }
                    finally
                    {
                        Logger.Log($"Inserting Backup Info Of {project?.ItemArray[1]?.ToString()}", BackupLogList, LogType.Backup);
                        int success = IsSuccessful ? 1 : 0;
                        await Task.Run(() => context.Query($"INSERT INTO Backups(Project,BackupDate,Successful) VALUES('{project?.ItemArray[1]?.ToString()}','{DateTime.Now}',{success})"));
                        Logger.Log($"Backup Info Inserted of {project?.ItemArray[1]?.ToString()}", BackupLogList, LogType.Backup);
                    }
                });
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                Logger.Log(ex.Message, ExpLogBackup, LogType.BackupException);
            }
            finally
            {
                Logger.Log("Backup Process End", BackupLogList, LogType.Backup);
                Logger.Log($"Project Backuped {ProjectBackuped} of {totalProjectToBackup}", BackupLogList, LogType.Backup);
                MessageBox.Show("Backup Completed Successfully", "Backup Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _home.GetBackups();
            }
        }

        private void UpdateProgress(int i, int max)
        {
            BackupProgress.Invoke(p => p.Value = i * BackupProgress.Maximum / max);
        }
    }
}
