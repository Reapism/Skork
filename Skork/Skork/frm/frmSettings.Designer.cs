namespace Skork.frm {
    partial class FrmSettings {
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
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.grpAbout = new System.Windows.Forms.GroupBox();
            this.grpSkorkAbout = new System.Windows.Forms.GroupBox();
            this.txtReadME = new System.Windows.Forms.RichTextBox();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.tabProject = new System.Windows.Forms.TabPage();
            this.grpProject = new System.Windows.Forms.GroupBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.tabGitHub = new System.Windows.Forms.TabPage();
            this.grpGitHub = new System.Windows.Forms.GroupBox();
            this.grpProj = new System.Windows.Forms.GroupBox();
            this.grpGo = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.grpAbout.SuspendLayout();
            this.grpSkorkAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            this.tabProject.SuspendLayout();
            this.grpProject.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabGitHub.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(864, 491);
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
            this.tabMain.Size = new System.Drawing.Size(864, 491);
            this.tabMain.TabIndex = 0;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.grpAbout);
            this.tabAbout.Location = new System.Drawing.Point(4, 4);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(856, 465);
            this.tabAbout.TabIndex = 4;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // grpAbout
            // 
            this.grpAbout.Controls.Add(this.grpSkorkAbout);
            this.grpAbout.Controls.Add(this.picAbout);
            this.grpAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAbout.Location = new System.Drawing.Point(3, 3);
            this.grpAbout.Name = "grpAbout";
            this.grpAbout.Size = new System.Drawing.Size(850, 459);
            this.grpAbout.TabIndex = 0;
            this.grpAbout.TabStop = false;
            this.grpAbout.Text = "About:";
            // 
            // grpSkorkAbout
            // 
            this.grpSkorkAbout.Controls.Add(this.txtReadME);
            this.grpSkorkAbout.Location = new System.Drawing.Point(6, 305);
            this.grpSkorkAbout.Name = "grpSkorkAbout";
            this.grpSkorkAbout.Size = new System.Drawing.Size(841, 128);
            this.grpSkorkAbout.TabIndex = 1;
            this.grpSkorkAbout.TabStop = false;
            this.grpSkorkAbout.Text = "Read ME:";
            // 
            // txtReadME
            // 
            this.txtReadME.Location = new System.Drawing.Point(6, 19);
            this.txtReadME.Name = "txtReadME";
            this.txtReadME.Size = new System.Drawing.Size(829, 103);
            this.txtReadME.TabIndex = 0;
            this.txtReadME.Text = "";
            this.txtReadME.ZoomFactor = 1.5F;
            // 
            // picAbout
            // 
            this.picAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAbout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAbout.Location = new System.Drawing.Point(250, 19);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(280, 280);
            this.picAbout.TabIndex = 0;
            this.picAbout.TabStop = false;
            this.picAbout.Click += new System.EventHandler(this.picAbout_Click);
            // 
            // tabProject
            // 
            this.tabProject.Controls.Add(this.grpProject);
            this.tabProject.Location = new System.Drawing.Point(4, 4);
            this.tabProject.Name = "tabProject";
            this.tabProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabProject.Size = new System.Drawing.Size(856, 465);
            this.tabProject.TabIndex = 2;
            this.tabProject.Text = "Project";
            this.tabProject.UseVisualStyleBackColor = true;
            // 
            // grpProject
            // 
            this.grpProject.Controls.Add(this.grpGo);
            this.grpProject.Controls.Add(this.grpProj);
            this.grpProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProject.Location = new System.Drawing.Point(3, 3);
            this.grpProject.Name = "grpProject";
            this.grpProject.Size = new System.Drawing.Size(850, 459);
            this.grpProject.TabIndex = 0;
            this.grpProject.TabStop = false;
            this.grpProject.Text = "Project:";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.grpSettings);
            this.tabSettings.Location = new System.Drawing.Point(4, 4);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(856, 465);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // grpSettings
            // 
            this.grpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSettings.Location = new System.Drawing.Point(3, 3);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(850, 459);
            this.grpSettings.TabIndex = 0;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings:";
            // 
            // tabGitHub
            // 
            this.tabGitHub.Controls.Add(this.grpGitHub);
            this.tabGitHub.Location = new System.Drawing.Point(4, 4);
            this.tabGitHub.Name = "tabGitHub";
            this.tabGitHub.Padding = new System.Windows.Forms.Padding(3);
            this.tabGitHub.Size = new System.Drawing.Size(856, 465);
            this.tabGitHub.TabIndex = 3;
            this.tabGitHub.Text = "GitHub";
            this.tabGitHub.UseVisualStyleBackColor = true;
            // 
            // grpGitHub
            // 
            this.grpGitHub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGitHub.Location = new System.Drawing.Point(3, 3);
            this.grpGitHub.Name = "grpGitHub";
            this.grpGitHub.Size = new System.Drawing.Size(850, 459);
            this.grpGitHub.TabIndex = 0;
            this.grpGitHub.TabStop = false;
            this.grpGitHub.Text = "GitHub:";
            // 
            // grpProj
            // 
            this.grpProj.Location = new System.Drawing.Point(6, 19);
            this.grpProj.Name = "grpProj";
            this.grpProj.Size = new System.Drawing.Size(391, 437);
            this.grpProj.TabIndex = 0;
            this.grpProj.TabStop = false;
            this.grpProj.Text = "Details:";
            // 
            // grpGo
            // 
            this.grpGo.Location = new System.Drawing.Point(456, 19);
            this.grpGo.Name = "grpGo";
            this.grpGo.Size = new System.Drawing.Size(391, 437);
            this.grpGo.TabIndex = 1;
            this.grpGo.TabStop = false;
            this.grpGo.Text = "Settings:";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 491);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.grpAbout.ResumeLayout(false);
            this.grpSkorkAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            this.tabProject.ResumeLayout(false);
            this.grpProject.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabGitHub.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabProject;
        private System.Windows.Forms.TabPage tabGitHub;
        private System.Windows.Forms.TabPage tabAbout;
        internal System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.GroupBox grpProject;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.GroupBox grpGitHub;
        internal System.Windows.Forms.GroupBox grpAbout;
        internal System.Windows.Forms.GroupBox grpSkorkAbout;
        private System.Windows.Forms.RichTextBox txtReadME;
        private System.Windows.Forms.GroupBox grpGo;
        private System.Windows.Forms.GroupBox grpProj;
    }
}