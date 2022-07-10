using System.IO.Compression;

namespace BackupEngine
{
    public static class Extensions
    {
        public static void Invoke<TControlType>(this TControlType control, Action<TControlType> del)
            where TControlType : Control
        {
            if (control.InvokeRequired)
                control.Invoke(new Action(() => del(control)));
            else
                del(control);
        }

        public static async Task ExtractToDirectory(this ZipArchive archive, string destinationDirectoryName, bool overwrite = true)
        {
            if (!overwrite)
            {
                await Task.Run(() => archive.ExtractToDirectory(destinationDirectoryName));
                return;
            }
           
            foreach (ZipArchiveEntry file in archive.Entries)
            {
                string completeFileName = Path.Combine(destinationDirectoryName, file.FullName);
                string? directory = await Task.Run(() => Path.GetDirectoryName(completeFileName));

                if (file.Name != "")
                {
                    await Task.Run(() => file.ExtractToFile(completeFileName, true));
                }
            }
        }
    }
}
