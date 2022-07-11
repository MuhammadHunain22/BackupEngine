using BackupEngine.Data;

namespace BackupEngine
{
    public partial class AddProject : Form
    {
        private readonly Uitility _uitility;
        private readonly DBContext _context;
        private readonly Home _home;
        public AddProject(Home home)
        {
            _uitility = new Uitility();
            _context = new DBContext();
            _home = home;
            InitializeComponent();
        }

        private async void AddProjectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string projectName = ProjectNameInput.Text;
                string projectPath = ProjectPathInput.Text;
                string backupPath = BackupPathInput.Text;

                if (string.IsNullOrWhiteSpace(projectName) || string.IsNullOrWhiteSpace(projectPath) || string.IsNullOrWhiteSpace(backupPath))
                {
                    MessageBox.Show("All Fields Are Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (projectName.Length < 2 || projectPath.Length < 2 || backupPath.Length < 2)
                {
                    MessageBox.Show("Fields Length Must Be Grater Than 2", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Path.IsPathRooted(projectPath))
                {
                    MessageBox.Show("Project Path Is Not A Valid Path", "Project Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Path.IsPathRooted(backupPath))
                {
                    MessageBox.Show("Backup Path Is Not A Valid Path", "Backup Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!await Task.Run(() => _uitility.CheckUnique("Projects", "ProjectName", projectName)))
                {
                    MessageBox.Show("Project Already Exsist", "Project Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!await Task.Run(() => _uitility.CheckUnique("Projects", "ProjectPath", projectPath)))
                {
                    MessageBox.Show("Project Path Already Exsist", "Project Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await Task.Run(() => _context.Query($"INSERT INTO PROJECTS(ProjectName,ProjectPath,BackupPath) VALUES('{projectName}','{projectPath}','{backupPath}')"));
                MessageBox.Show("Project Created Successfully", "Project Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _home.UpdateDataGrid();
                Close();
                return;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void ProjectPathDailogBtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    ProjectPathInput.Text = fbd.SelectedPath;
                }
            }
        }

        private void BackPathDailogBtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    BackupPathInput.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
