using BackupEngine.Data;
using System.Data;
using System.IO.Compression;

namespace BackupEngine
{
    public partial class RollBack : Form
    {
        private readonly DBContext context;
        private int totalProjectToRollback = 0;
        private int ProjectRollbacked = 0;
        public RollBack()
        {
            context = new DBContext();
            InitializeComponent();
            StartRollback();
        }

        internal async void StartRollback()
        {
            try
            {
                Logger.Log("Starting RollBack", RollbackLogList, LogType.Normal);
                DataTable projects = await Task.Run(() => context.GetWhere("Projects", "IsBackup=1", "*"));
                Logger.Log($"{projects.Rows.Count} Projects Found To Rollback", RollbackLogList, LogType.Normal);

                if (projects.Rows.Count == 0)
                {
                    return;
                }

                totalProjectToRollback = projects.Rows.Count;
                List<DataRow> projectList = await Task.Run(() => projects.AsEnumerable().ToList());
                
               await Rollback(projectList);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, ExpLogRollback, LogType.Exception);
            }
            finally
            {
                Logger.Log("Rollback Process End", RollbackLogList, LogType.Normal);
                Logger.Log($"Project Rollbacked {ProjectRollbacked} of {totalProjectToRollback}", RollbackLogList, LogType.Normal);
                MessageBox.Show("Rollback Completed Successfully", "Backup Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal async Task Rollback(List<DataRow> projectList)
        {
            ParallelOptions parallelOptions = new()
            {
                MaxDegreeOfParallelism = 5,
            };

            int i = 0;
            await Parallel.ForEachAsync(projectList, parallelOptions, async (project, token) =>
            {
                try
                {
                    Logger.Log($"Started RollBack Of {project?.ItemArray[1]?.ToString()}", RollbackLogList, LogType.Normal);

                    if (!File.Exists(Path.Combine($@"{project?.ItemArray[3]?.ToString()}", $@"{project?.ItemArray[1]?.ToString()}\{DateTime.UtcNow.ToString("dd-MM-yyyy")}-{project?.ItemArray[1]?.ToString()}.zip")))
                    {
                        Logger.Log($"Backup File Not Exist Of {project?.ItemArray[1]?.ToString()}", RollbackLogList, LogType.Normal);
                        return;
                    }

                    Logger.Log($"Backup File Found Of {project?.ItemArray[1]?.ToString()}", RollbackLogList, LogType.Normal);

                    if (!await Task.Run(() => Directory.Exists($@"{project?.ItemArray[2]?.ToString()}")))
                    {
                        Logger.Log($@"No Project Directory Found To Backup on {project?.ItemArray[2]?.ToString()}", RollbackLogList, LogType.Normal);
                        return;
                    }

                    Logger.Log($@"Rollback Dir of {project?.ItemArray[1]?.ToString()} found on {project?.ItemArray[2]?.ToString()}", RollbackLogList, LogType.Normal);

                    Logger.Log($"Start Unziping Of {project?.ItemArray[1]?.ToString()}", RollbackLogList, LogType.Normal);

                    using (var strm = await Task.Run(() => File.OpenRead(Path.Combine($@"{project?.ItemArray[3]?.ToString()}", $@"{project?.ItemArray[1]?.ToString()}\{DateTime.UtcNow.ToString("dd-MM-yyyy")}-{project?.ItemArray[1]?.ToString()}.zip"))))
                    using (ZipArchive archive = new ZipArchive(strm))
                    {
                        await archive.ExtractToDirectory($@"{project?.ItemArray[2]?.ToString()}");
                    }

                    i++;
                    await Task.Run(() => UpdateProgress(i, projectList.Count));
                    Logger.Log($"Unziping Complete Of {project?.ItemArray[1]?.ToString()}", RollbackLogList, LogType.Normal);
                    Logger.Log($"RollBack Done Of {project?.ItemArray[1]?.ToString()}", RollbackLogList, LogType.Normal);
                    ProjectRollbacked++;
                }
                catch (UnauthorizedAccessException ex)
                {
                    Logger.Log($"{ex.Message} Please Give Permissions to Access The Folder", ExpLogRollback, LogType.Exception);

                }
                catch (Exception ex)
                {
                    _ = ex.Message;
                    Logger.Log(ex.Message, ExpLogRollback, LogType.Exception);
                }
            });
        }

        private void UpdateProgress(int i, int max)
        {
            RollbackProgress.Invoke(p => p.Value = i * RollbackProgress.Maximum / max);
        }
    }
}
