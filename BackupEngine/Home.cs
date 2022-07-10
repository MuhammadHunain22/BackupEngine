using BackupEngine.Data;

namespace BackupEngine
{
    public partial class Home : Form
    {
        private readonly DBContext context;
        public Home()
        {
            context = new DBContext();
            InitializeComponent();
            UpdateDataGrid();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            try
            {
                new Settings().ShowDialog();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                new AddProject(this).ShowDialog();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        public void UpdateDataGrid()
        {
            try
            {
                Projects.DataSource = context.Get("Projects", "ProjectName", "ProjectPath", "BackupPath");
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void Backup_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to start backup ?","Projects Backup" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                 new Backup().ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void RollbackBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to start rollback ?", "Projects Rollback", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                new RollBack().ShowDialog();
            }
            else
            {
                return;
            }
        }
    }
}