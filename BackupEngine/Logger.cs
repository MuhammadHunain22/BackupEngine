namespace BackupEngine
{
    internal enum LogType
    {
        Normal = 1,
        Exception = 2
    }
    internal static class Logger
    {
        internal static void Log(string log, ListBox listBox, LogType logType)
        {
            try
            {
                if(listBox.Items.Count > 1000)
                {
                   listBox.Invoke(l => l.Items.Clear());
                }

                listBox.Invoke(l => l.Items.Add($"{DateTime.UtcNow.ToString()} {log}"));
                listBox.Invoke(l => l.SelectedIndex = listBox.Items.Count-1);

                if (!Directory.Exists($@".\Logs"))
                {
                    Directory.CreateDirectory($@".\Logs");
                }

                string logPath = logType == LogType.Normal ? $@".\Logs\Log.txt" : $@".\Logs\ExceptionLog.txt";
                File.AppendAllText(logPath, $"{DateTime.UtcNow.ToString()} {log}\n");
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }
    }
}
