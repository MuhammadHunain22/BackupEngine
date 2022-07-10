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
            this.Settings = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Backup = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Projects = new System.Windows.Forms.DataGridView();
            this.RollbackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projects)).BeginInit();
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
            this.Projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Projects.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.Projects.Location = new System.Drawing.Point(12, 98);
            this.Projects.Name = "Projects";
            this.Projects.RowTemplate.Height = 25;
            this.Projects.Size = new System.Drawing.Size(776, 340);
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RollbackBtn);
            this.Controls.Add(this.Projects);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Backup);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Settings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Settings;
        private Button Add;
        private Button Backup;
        private PictureBox Logo;
        private DataGridView Projects;
        private Button RollbackBtn;
    }
}