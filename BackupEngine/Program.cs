namespace BackupEngine
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Logger.Log($"Engine Started", null, LogType.Normal);
                ApplicationConfiguration.Initialize();
                Application.Run(new Home());
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                Logger.Log($"{ex.Message}",null,LogType.Exception);
            }
        }
    }
}