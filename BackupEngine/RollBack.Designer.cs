namespace BackupEngine
{
    partial class RollBack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RollBack));
            this.ExpLogRollback = new System.Windows.Forms.ListBox();
            this.RollbackProgress = new System.Windows.Forms.ProgressBar();
            this.RollbackLogList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ExpLogRollback
            // 
            this.ExpLogRollback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpLogRollback.FormattingEnabled = true;
            this.ExpLogRollback.ItemHeight = 15;
            this.ExpLogRollback.Location = new System.Drawing.Point(12, 254);
            this.ExpLogRollback.Name = "ExpLogRollback";
            this.ExpLogRollback.Size = new System.Drawing.Size(776, 184);
            this.ExpLogRollback.TabIndex = 5;
            // 
            // RollbackProgress
            // 
            this.RollbackProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RollbackProgress.Location = new System.Drawing.Point(12, 210);
            this.RollbackProgress.Name = "RollbackProgress";
            this.RollbackProgress.Size = new System.Drawing.Size(776, 23);
            this.RollbackProgress.TabIndex = 4;
            // 
            // RollbackLogList
            // 
            this.RollbackLogList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RollbackLogList.FormattingEnabled = true;
            this.RollbackLogList.ItemHeight = 15;
            this.RollbackLogList.Location = new System.Drawing.Point(12, 12);
            this.RollbackLogList.Name = "RollbackLogList";
            this.RollbackLogList.Size = new System.Drawing.Size(776, 184);
            this.RollbackLogList.TabIndex = 3;
            // 
            // RollBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExpLogRollback);
            this.Controls.Add(this.RollbackProgress);
            this.Controls.Add(this.RollbackLogList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RollBack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RollBack";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox ExpLogRollback;
        private ProgressBar RollbackProgress;
        private ListBox RollbackLogList;
    }
}