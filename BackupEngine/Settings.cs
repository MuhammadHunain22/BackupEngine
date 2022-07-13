using BackupEngine.Data;
using System.Data;

namespace BackupEngine
{
    public partial class Settings : Form
    {
        private readonly DBContext _context;
        public Settings()
        {
            _context = new DBContext();
            InitializeComponent();
            DataTable table = _context.Get("Projects", "ProjectName", "IsBackup");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                try
                {
                    CheckBox box = new CheckBox();
                    box.Checked = Convert.ToBoolean(table.Rows[i]["IsBackup"]);
                    box.Width = 260;
                    box.Height = 20;
                    box.Text = table.Rows[i]["ProjectName"].ToString();
                    box.CheckedChanged += new EventHandler(CheckBoxChanged);
                    ScroolViewSettings.Controls.Add(box);
                }catch (Exception ex)
                {
                    _ = ex.Message;
                    Logger.Log(ex.Message, null, LogType.Exception);
                    continue;
                }
            }
        }

        private async void CheckBoxChanged(object sender,EventArgs e)
        {
            try
            {
                CheckBox chk = sender as CheckBox;
                int isChk = chk.Checked ? 1 : 0;
                await Task.Run(() => _context.Query($"UPDATE PROJECTS SET IsBackup={isChk} WHERE ProjectName='{chk.Text}'"));
            }catch(Exception ex)
            {
                _ = ex.Message;
                Logger.Log(ex.Message, null, LogType.Exception);
            }
        }



    }
}
