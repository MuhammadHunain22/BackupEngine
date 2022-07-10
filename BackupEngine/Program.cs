namespace BackupEngine
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Home());
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }
    }
}