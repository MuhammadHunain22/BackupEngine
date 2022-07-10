namespace BackupEngine.Models
{
    internal class Project
    {
        public int Id { get; set; }
        public int ProjectPath { get; set; }
        public int BackupPath { get; set; }
        public int IsBackup { get; set; }
    }
}
