using BackupEngine.Data;
using System.Data;
using System.IO.Compression;

namespace BackupEngine
{
    public partial class Backup : Form
    {
        private readonly DBContext context;

        public Backup()
        {
            context = new DBContext();
            InitializeComponent();
            StartBackup();
        }

        private async void StartBackup()
        {
            int totalProjectToBackup = 0;
            int ProjectBackuped = 0;
            try
            {
                Logger.Log("Starting Backup", BackupLogList, LogType.Normal);
                DataTable projects = await Task.Run(() => context.GetWhere("Projects", "IsBackup=1", "*"));
                Logger.Log($"{projects.Rows.Count} Projects Found To Backup", BackupLogList, LogType.Normal);

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
                    try
                    {
                        i++;
                        Logger.Log($"Started Backup Of {project?.ItemArray[1]?.ToString()}", BackupLogList, LogType.Normal);
                        if (!await Task.Run(() => Directory.Exists($@"{project?.ItemArray[2]?.ToString()}")))
                        {
                            Logger.Log($@"No Project Directory Found on {project?.ItemArray[2]?.ToString()}", BackupLogList, LogType.Normal);
                            return;
                        }

                        if (File.Exists(Path.Combine($@"{project?.ItemArray[3]?.ToString()}", $@"{project?.ItemArray[1]?.ToString()}\{DateTime.UtcNow.ToString("dd-MM-yyyy")}-{project?.ItemArray[1]?.ToString()}.zip")))
                        {
                            Logger.Log($"Backup Already Exist Of {project?.ItemArray[1]?.ToString()}", BackupLogList, LogType.Normal);
                            return;
                        }

                        Logger.Log($@"Project {project?.ItemArray[1]?.ToString()} found on {project?.ItemArray[2]?.ToString()}", BackupLogList, LogType.Normal);
                       
                        if (!await Task.Run(() => Directory.Exists(Path.Combine($@"{project?.ItemArray[3]?.ToString()}", $@"{project?.ItemArray[1]?.ToString()}"))))
                        {
                            Logger.Log($"Creating Backup Directory Of {project?.ItemArray[1]?.ToString()}", BackupLogList, LogType.Normal);
                            await Task.Run(() => Directory.CreateDirectory(Path.Combine($@"{project?.ItemArray[3]?.ToString()}", $@"{project?.ItemArray[1]?.ToString()}")));
                        }

                        Logger.Log($"Start Ziping Of {project?.ItemArray[1]?.ToString()}", BackupLogList, LogType.Normal);
                        await Task.Run(() => ZipFile.CreateFromDirectory($@"{project?.ItemArray[2]?.ToString()}", Path.Combine($@"{project?.ItemArray[3]?.ToString()}", $@"{project?.ItemArray[1]?.ToString()}\{DateTime.UtcNow.ToString("dd-MM-yyyy")}-{project?.ItemArray[1]?.ToString()}.zip")));
                        await Task.Run(() => UpdateProgress(i, projectList.Count));
                        Logger.Log($"Ziping Complete Of {project?.ItemArray[1]?.ToString()}", BackupLogList, LogType.Normal);
                        Logger.Log($"Backup Done Of {project?.ItemArray[1]?.ToString()}", BackupLogList, LogType.Normal);
                        ProjectBackuped++;
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        Logger.Log($"{ex.Message} Please Give Permissions to Access The Folder", ExpLogBackup, LogType.Exception);

                    }
                    catch (Exception ex)
                    {
                        _ = ex.Message;
                        Logger.Log(ex.Message, ExpLogBackup, LogType.Exception);
                    }
                });
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                Logger.Log(ex.Message, ExpLogBackup, LogType.Exception);
            }
            finally
            {
                Logger.Log("Backup Process End", BackupLogList, LogType.Normal);
                Logger.Log($"Project Backuped {ProjectBackuped} of {totalProjectToBackup}", BackupLogList, LogType.Normal);
                MessageBox.Show("Backup Completed Successfully", "Backup Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void UpdateProgress(int i, int max)
        {
            BackupProgress.Invoke(p => p.Value = i * BackupProgress.Maximum / max);
        }
    }
}
