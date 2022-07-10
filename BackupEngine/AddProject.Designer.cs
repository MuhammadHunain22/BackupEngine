namespace BackupEngine
{
    partial class AddProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProject));
            this.AddprojectHeading = new System.Windows.Forms.Label();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.ProjectNameInput = new System.Windows.Forms.TextBox();
            this.ProjectPathInput = new System.Windows.Forms.TextBox();
            this.ProjectPathLabel = new System.Windows.Forms.Label();
            this.BackupPathInput = new System.Windows.Forms.TextBox();
            this.BackupPathLabel = new System.Windows.Forms.Label();
            this.AddProjectBtn = new System.Windows.Forms.Button();
            this.ProjectPathDailogBtn = new System.Windows.Forms.Button();
            this.BackPathDailogBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddprojectHeading
            // 
            this.AddprojectHeading.AutoSize = true;
            this.AddprojectHeading.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddprojectHeading.Location = new System.Drawing.Point(119, 16);
            this.AddprojectHeading.Name = "AddprojectHeading";
            this.AddprojectHeading.Size = new System.Drawing.Size(146, 28);
            this.AddprojectHeading.TabIndex = 0;
            this.AddprojectHeading.Text = "ADD PROJECT";
            this.AddprojectHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectNameLabel.Location = new System.Drawing.Point(12, 71);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(91, 19);
            this.ProjectNameLabel.TabIndex = 1;
            this.ProjectNameLabel.Text = "Project Name";
            // 
            // ProjectNameInput
            // 
            this.ProjectNameInput.Location = new System.Drawing.Point(15, 98);
            this.ProjectNameInput.Name = "ProjectNameInput";
            this.ProjectNameInput.Size = new System.Drawing.Size(357, 23);
            this.ProjectNameInput.TabIndex = 0;
            // 
            // ProjectPathInput
            // 
            this.ProjectPathInput.Location = new System.Drawing.Point(15, 159);
            this.ProjectPathInput.Name = "ProjectPathInput";
            this.ProjectPathInput.Size = new System.Drawing.Size(322, 23);
            this.ProjectPathInput.TabIndex = 1;
            // 
            // ProjectPathLabel
            // 
            this.ProjectPathLabel.AutoSize = true;
            this.ProjectPathLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectPathLabel.Location = new System.Drawing.Point(12, 132);
            this.ProjectPathLabel.Name = "ProjectPathLabel";
            this.ProjectPathLabel.Size = new System.Drawing.Size(87, 19);
            this.ProjectPathLabel.TabIndex = 3;
            this.ProjectPathLabel.Text = "Project  Path";
            // 
            // BackupPathInput
            // 
            this.BackupPathInput.Location = new System.Drawing.Point(15, 220);
            this.BackupPathInput.Name = "BackupPathInput";
            this.BackupPathInput.Size = new System.Drawing.Size(322, 23);
            this.BackupPathInput.TabIndex = 2;
            // 
            // BackupPathLabel
            // 
            this.BackupPathLabel.AutoSize = true;
            this.BackupPathLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackupPathLabel.Location = new System.Drawing.Point(12, 193);
            this.BackupPathLabel.Name = "BackupPathLabel";
            this.BackupPathLabel.Size = new System.Drawing.Size(85, 19);
            this.BackupPathLabel.TabIndex = 5;
            this.BackupPathLabel.Text = "Backup Path";
            // 
            // AddProjectBtn
            // 
            this.AddProjectBtn.Location = new System.Drawing.Point(130, 276);
            this.AddProjectBtn.Name = "AddProjectBtn";
            this.AddProjectBtn.Size = new System.Drawing.Size(118, 39);
            this.AddProjectBtn.TabIndex = 6;
            this.AddProjectBtn.Text = "Add";
            this.AddProjectBtn.UseVisualStyleBackColor = true;
            this.AddProjectBtn.Click += new System.EventHandler(this.AddProjectBtn_Click);
            // 
            // ProjectPathDailogBtn
            // 
            this.ProjectPathDailogBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectPathDailogBtn.Location = new System.Drawing.Point(343, 158);
            this.ProjectPathDailogBtn.Name = "ProjectPathDailogBtn";
            this.ProjectPathDailogBtn.Size = new System.Drawing.Size(29, 24);
            this.ProjectPathDailogBtn.TabIndex = 7;
            this.ProjectPathDailogBtn.Text = "...";
            this.ProjectPathDailogBtn.UseVisualStyleBackColor = true;
            this.ProjectPathDailogBtn.Click += new System.EventHandler(this.ProjectPathDailogBtn_Click);
            // 
            // BackPathDailogBtn
            // 
            this.BackPathDailogBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackPathDailogBtn.Location = new System.Drawing.Point(343, 219);
            this.BackPathDailogBtn.Name = "BackPathDailogBtn";
            this.BackPathDailogBtn.Size = new System.Drawing.Size(29, 24);
            this.BackPathDailogBtn.TabIndex = 8;
            this.BackPathDailogBtn.Text = "...";
            this.BackPathDailogBtn.UseVisualStyleBackColor = true;
            this.BackPathDailogBtn.Click += new System.EventHandler(this.BackPathDailogBtn_Click);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.BackPathDailogBtn);
            this.Controls.Add(this.ProjectPathDailogBtn);
            this.Controls.Add(this.AddProjectBtn);
            this.Controls.Add(this.BackupPathInput);
            this.Controls.Add(this.BackupPathLabel);
            this.Controls.Add(this.ProjectPathInput);
            this.Controls.Add(this.ProjectPathLabel);
            this.Controls.Add(this.ProjectNameInput);
            this.Controls.Add(this.ProjectNameLabel);
            this.Controls.Add(this.AddprojectHeading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "AddProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AddprojectHeading;
        private Label ProjectNameLabel;
        private TextBox ProjectNameInput;
        private TextBox ProjectPathInput;
        private Label ProjectPathLabel;
        private TextBox BackupPathInput;
        private Label BackupPathLabel;
        private Button AddProjectBtn;
        private Button ProjectPathDailogBtn;
        private Button BackPathDailogBtn;
    }
}