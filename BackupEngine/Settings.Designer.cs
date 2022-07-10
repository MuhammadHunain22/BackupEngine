namespace BackupEngine
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.ScroolViewSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.SettingsHeading = new System.Windows.Forms.Label();
            this.ScroolViewSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScroolViewSettings
            // 
            this.ScroolViewSettings.AutoScroll = true;
            this.ScroolViewSettings.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ScroolViewSettings.Controls.Add(this.SettingsHeading);
            this.ScroolViewSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScroolViewSettings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ScroolViewSettings.Location = new System.Drawing.Point(0, 0);
            this.ScroolViewSettings.Margin = new System.Windows.Forms.Padding(0);
            this.ScroolViewSettings.Name = "ScroolViewSettings";
            this.ScroolViewSettings.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.ScroolViewSettings.Size = new System.Drawing.Size(284, 261);
            this.ScroolViewSettings.TabIndex = 0;
            this.ScroolViewSettings.WrapContents = false;
            // 
            // SettingsHeading
            // 
            this.SettingsHeading.AutoSize = true;
            this.SettingsHeading.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SettingsHeading.Location = new System.Drawing.Point(13, 15);
            this.SettingsHeading.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.SettingsHeading.MinimumSize = new System.Drawing.Size(260, 0);
            this.SettingsHeading.Name = "SettingsHeading";
            this.SettingsHeading.Size = new System.Drawing.Size(260, 28);
            this.SettingsHeading.TabIndex = 1;
            this.SettingsHeading.Text = "SETTINGS";
            this.SettingsHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ScroolViewSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ScroolViewSettings.ResumeLayout(false);
            this.ScroolViewSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel ScroolViewSettings;
        private Label SettingsHeading;
    }
}