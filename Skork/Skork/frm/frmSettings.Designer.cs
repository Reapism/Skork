namespace Skork.frm {
    partial class frmSettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tabProject = new System.Windows.Forms.TabPage();
            this.tabGitHub = new System.Windows.Forms.TabPage();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.grpAbout = new System.Windows.Forms.GroupBox();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.grpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(864, 471);
            this.pnlMain.TabIndex = 1;
            // 
            // tabMain
            // 
            this.tabMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabMain.Controls.Add(this.tabAbout);
            this.tabMain.Controls.Add(this.tabProject);
            this.tabMain.Controls.Add(this.tabSettings);
            this.tabMain.Controls.Add(this.tabGitHub);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(864, 471);
            this.tabMain.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.Location = new System.Drawing.Point(4, 4);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(856, 445);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tabProject
            // 
            this.tabProject.Location = new System.Drawing.Point(4, 4);
            this.tabProject.Name = "tabProject";
            this.tabProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabProject.Size = new System.Drawing.Size(467, 158);
            this.tabProject.TabIndex = 2;
            this.tabProject.Text = "Project";
            this.tabProject.UseVisualStyleBackColor = true;
            // 
            // tabGitHub
            // 
            this.tabGitHub.Location = new System.Drawing.Point(4, 4);
            this.tabGitHub.Name = "tabGitHub";
            this.tabGitHub.Padding = new System.Windows.Forms.Padding(3);
            this.tabGitHub.Size = new System.Drawing.Size(467, 158);
            this.tabGitHub.TabIndex = 3;
            this.tabGitHub.Text = "GitHub";
            this.tabGitHub.UseVisualStyleBackColor = true;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.grpAbout);
            this.tabAbout.Location = new System.Drawing.Point(4, 4);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(856, 445);
            this.tabAbout.TabIndex = 4;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // grpAbout
            // 
            this.grpAbout.Controls.Add(this.picAbout);
            this.grpAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAbout.Location = new System.Drawing.Point(3, 3);
            this.grpAbout.Name = "grpAbout";
            this.grpAbout.Size = new System.Drawing.Size(850, 439);
            this.grpAbout.TabIndex = 0;
            this.grpAbout.TabStop = false;
            this.grpAbout.Text = "About:";
            // 
            // picAbout
            // 
            this.picAbout.Location = new System.Drawing.Point(250, 19);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(283, 262);
            this.picAbout.TabIndex = 0;
            this.picAbout.TabStop = false;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 471);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.grpAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabProject;
        private System.Windows.Forms.TabPage tabGitHub;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.GroupBox grpAbout;
        internal System.Windows.Forms.PictureBox picAbout;
    }
}