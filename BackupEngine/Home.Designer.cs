namespace BackupEngine
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Settings = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Backup = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Projects = new System.Windows.Forms.DataGridView();
            this.RollbackBtn = new System.Windows.Forms.Button();
            this.HomeTabControl = new System.Windows.Forms.TabControl();
            this.ProjectsTab = new System.Windows.Forms.TabPage();
            this.BackupsTab = new System.Windows.Forms.TabPage();
            this.BackupsTable = new System.Windows.Forms.DataGridView();
            this.RollbacksTab = new System.Windows.Forms.TabPage();
            this.RollbackTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projects)).BeginInit();
            this.HomeTabControl.SuspendLayout();
            this.ProjectsTab.SuspendLayout();
            this.BackupsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupsTable)).BeginInit();
            this.RollbacksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RollbackTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Settings
            // 
            this.Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settings.BackgroundImage")));
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Location = new System.Drawing.Point(748, 12);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(40, 41);
            this.Settings.TabIndex = 0;
            this.Settings.TabStop = false;
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add.BackgroundImage")));
            this.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Location = new System.Drawing.Point(698, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(40, 41);
            this.Add.TabIndex = 1;
            this.Add.TabStop = false;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Backup
            // 
            this.Backup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Backup.BackColor = System.Drawing.Color.Transparent;
            this.Backup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Backup.BackgroundImage")));
            this.Backup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Backup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Backup.FlatAppearance.BorderSize = 0;
            this.Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backup.Location = new System.Drawing.Point(652, 12);
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(40, 41);
            this.Backup.TabIndex = 2;
            this.Backup.TabStop = false;
            this.Backup.UseVisualStyleBackColor = false;
            this.Backup.Click += new System.EventHandler(this.Backup_Click);
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(128, 56);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // Projects
            // 
            this.Projects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Projects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Projects.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Projects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Projects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Projects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Projects.DefaultCellStyle = dataGridViewCellStyle2;
            this.Projects.GridColor = System.Drawing.SystemColors.Info;
            this.Projects.Location = new System.Drawing.Point(-4, 0);
            this.Projects.Name = "Projects";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            this.Projects.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Projects.RowTemplate.Height = 25;
            this.Projects.Size = new System.Drawing.Size(776, 322);
            this.Projects.TabIndex = 4;
            // 
            // RollbackBtn
            // 
            this.RollbackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RollbackBtn.BackColor = System.Drawing.Color.Transparent;
            this.RollbackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RollbackBtn.BackgroundImage")));
            this.RollbackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RollbackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RollbackBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RollbackBtn.FlatAppearance.BorderSize = 0;
            this.RollbackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RollbackBtn.Location = new System.Drawing.Point(605, 12);
            this.RollbackBtn.Name = "RollbackBtn";
            this.RollbackBtn.Size = new System.Drawing.Size(40, 41);
            this.RollbackBtn.TabIndex = 5;
            this.RollbackBtn.TabStop = false;
            this.RollbackBtn.UseVisualStyleBackColor = false;
            this.RollbackBtn.Click += new System.EventHandler(this.RollbackBtn_Click);
            // 
            // HomeTabControl
            // 
            this.HomeTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeTabControl.Controls.Add(this.ProjectsTab);
            this.HomeTabControl.Controls.Add(this.BackupsTab);
            this.HomeTabControl.Controls.Add(this.RollbacksTab);
            this.HomeTabControl.Location = new System.Drawing.Point(12, 92);
            this.HomeTabControl.Name = "HomeTabControl";
            this.HomeTabControl.SelectedIndex = 0;
            this.HomeTabControl.Size = new System.Drawing.Size(776, 346);
            this.HomeTabControl.TabIndex = 6;
            // 
            // ProjectsTab
            // 
            this.ProjectsTab.Controls.Add(this.Projects);
            this.ProjectsTab.Location = new System.Drawing.Point(4, 24);
            this.ProjectsTab.Name = "ProjectsTab";
            this.ProjectsTab.Size = new System.Drawing.Size(768, 318);
            this.ProjectsTab.TabIndex = 0;
            this.ProjectsTab.Text = "Projects";
            this.ProjectsTab.UseVisualStyleBackColor = true;
            // 
            // BackupsTab
            // 
            this.BackupsTab.Controls.Add(this.BackupsTable);
            this.BackupsTab.Location = new System.Drawing.Point(4, 24);
            this.BackupsTab.Name = "BackupsTab";
            this.BackupsTab.Padding = new System.Windows.Forms.Padding(3);
            this.BackupsTab.Size = new System.Drawing.Size(768, 318);
            this.BackupsTab.TabIndex = 1;
            this.BackupsTab.Text = "Backups";
            this.BackupsTab.UseVisualStyleBackColor = true;
            // 
            // BackupsTable
            // 
            this.BackupsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackupsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BackupsTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackupsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BackupsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.BackupsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BackupsTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.BackupsTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackupsTable.Location = new System.Drawing.Point(-4, 0);
            this.BackupsTable.Name = "BackupsTable";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            this.BackupsTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.BackupsTable.RowTemplate.Height = 25;
            this.BackupsTable.Size = new System.Drawing.Size(772, 322);
            this.BackupsTable.TabIndex = 5;
            // 
            // RollbacksTab
            // 
            this.RollbacksTab.Controls.Add(this.RollbackTable);
            this.RollbacksTab.Location = new System.Drawing.Point(4, 24);
            this.RollbacksTab.Name = "RollbacksTab";
            this.RollbacksTab.Size = new System.Drawing.Size(768, 318);
            this.RollbacksTab.TabIndex = 2;
            this.RollbacksTab.Text = "Rollbacks";
            this.RollbacksTab.UseVisualStyleBackColor = true;
            // 
            // RollbackTable
            // 
            this.RollbackTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RollbackTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RollbackTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RollbackTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RollbackTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.RollbackTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RollbackTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.RollbackTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.RollbackTable.Location = new System.Drawing.Point(-4, 0);
            this.RollbackTable.Name = "RollbackTable";
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(3);
            this.RollbackTable.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.RollbackTable.RowTemplate.Height = 25;
            this.RollbackTable.Size = new System.Drawing.Size(776, 322);
            this.RollbackTable.TabIndex = 5;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeTabControl);
            this.Controls.Add(this.RollbackBtn);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Backup);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Settings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Engine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projects)).EndInit();
            this.HomeTabControl.ResumeLayout(false);
            this.ProjectsTab.ResumeLayout(false);
            this.BackupsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackupsTable)).EndInit();
            this.RollbacksTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RollbackTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Settings;
        private Button Add;
        private Button Backup;
        private PictureBox Logo;
        private DataGridView Projects;
        private Button RollbackBtn;
        private TabControl HomeTabControl;
        private TabPage ProjectsTab;
        private TabPage BackupsTab;
        private TabPage RollbacksTab;
        private DataGridView BackupsTable;
        private DataGridView RollbackTable;
    }
}