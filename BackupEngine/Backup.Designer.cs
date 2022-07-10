namespace BackupEngine
{
    partial class Backup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackupLogList = new System.Windows.Forms.ListBox();
            this.BackupProgress = new System.Windows.Forms.ProgressBar();
            this.ExpLogBackup = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BackupLogList
            // 
            this.BackupLogList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackupLogList.FormattingEnabled = true;
            this.BackupLogList.ItemHeight = 15;
            this.BackupLogList.Location = new System.Drawing.Point(12, 12);
            this.BackupLogList.Name = "BackupLogList";
            this.BackupLogList.Size = new System.Drawing.Size(776, 184);
            this.BackupLogList.TabIndex = 0;
            // 
            // BackupProgress
            // 
            this.BackupProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackupProgress.Location = new System.Drawing.Point(12, 210);
            this.BackupProgress.Name = "BackupProgress";
            this.BackupProgress.Size = new System.Drawing.Size(776, 23);
            this.BackupProgress.TabIndex = 1;
            // 
            // ExpLogBackup
            // 
            this.ExpLogBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpLogBackup.FormattingEnabled = true;
            this.ExpLogBackup.ItemHeight = 15;
            this.ExpLogBackup.Location = new System.Drawing.Point(12, 254);
            this.ExpLogBackup.Name = "ExpLogBackup";
            this.ExpLogBackup.Size = new System.Drawing.Size(776, 184);
            this.ExpLogBackup.TabIndex = 2;
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExpLogBackup);
            this.Controls.Add(this.BackupProgress);
            this.Controls.Add(this.BackupLogList);
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox BackupLogList;
        private ProgressBar BackupProgress;
        private ListBox ExpLogBackup;
    }
}