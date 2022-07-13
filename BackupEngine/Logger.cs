namespace BackupEngine
{
    internal enum LogType
    {
        Normal = 1,
        Exception = 2,
        Backup = 3,
        BackupException = 4,
        RollBack = 5,
        RollBackException = 6
    }
    internal static class Logger
    {
        internal static void Log(string log, ListBox? listBox, LogType logType)
        {
            try
            {
                if (listBox != null)
                {
                    if (listBox.Items.Count > 1000)
                    {
                        listBox.Invoke(l => l.Items.Clear());
                    }

                    listBox.Invoke(l => l.Items.Add($"{DateTime.UtcNow.ToString()} {log}"));
                    listBox.Invoke(l => l.SelectedIndex = listBox.Items.Count - 1);
                }

                if (!Directory.Exists($@".\Logs"))
                {
                    Directory.CreateDirectory($@".\Logs");
                }

                string logPath = logType == LogType.Normal ? $@".\Logs\Log.txt" : $@".\Logs\{Enum.GetName(logType)}.txt";
                File.AppendAllText(logPath, $"{DateTime.Now.ToString()} {log}\n");
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                if (!Directory.Exists($@".\Logs"))
                {
                    Directory.CreateDirectory($@".\Logs");
                }

                string logPath = $@".\Logs\{Enum.GetName(LogType.Exception)}.txt";
                File.AppendAllText(logPath, $"{DateTime.Now.ToString()} {ex.Message}\n");
            }
        }
    }
}
