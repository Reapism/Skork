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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tMain = new System.Windows.Forms.TabControl();
            this.tAbout = new System.Windows.Forms.TabPage();
            this.grpAbout = new System.Windows.Forms.GroupBox();
            this.grpAboutChild = new System.Windows.Forms.GroupBox();
            this.txtReadME = new System.Windows.Forms.RichTextBox();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.tProject = new System.Windows.Forms.TabPage();
            this.grp = new System.Windows.Forms.GroupBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.tsProject = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripDropDownButton();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnView = new System.Windows.Forms.ToolStripDropDownButton();
            this.tPreferences = new System.Windows.Forms.TabPage();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.tGitHub = new System.Windows.Forms.TabPage();
            this.grpGitHub = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.tMain.SuspendLayout();
            this.tAbout.SuspendLayout();
            this.grpAbout.SuspendLayout();
            this.grpAboutChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            this.tProject.SuspendLayout();
            this.tsProject.SuspendLayout();
            this.tPreferences.SuspendLayout();
            this.tGitHub.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(864, 491);
            this.pnlMain.TabIndex = 1;
            // 
            // tMain
            // 
            this.tMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tMain.Controls.Add(this.tAbout);
            this.tMain.Controls.Add(this.tProject);
            this.tMain.Controls.Add(this.tPreferences);
            this.tMain.Controls.Add(this.tGitHub);
            this.tMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMain.Location = new System.Drawing.Point(0, 0);
            this.tMain.Name = "tMain";
            this.tMain.SelectedIndex = 0;
            this.tMain.Size = new System.Drawing.Size(864, 491);
            this.tMain.TabIndex = 0;
            this.tMain.SelectedIndexChanged += new System.EventHandler(this.tMain_SelectedIndexChanged);
            // 
            // tAbout
            // 
            this.tAbout.Controls.Add(this.grpAbout);
            this.tAbout.Location = new System.Drawing.Point(4, 4);
            this.tAbout.Name = "tAbout";
            this.tAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tAbout.Size = new System.Drawing.Size(856, 465);
            this.tAbout.TabIndex = 4;
            this.tAbout.Text = "About";
            this.tAbout.UseVisualStyleBackColor = true;
            // 
            // grpAbout
            // 
            this.grpAbout.Controls.Add(this.grpAboutChild);
            this.grpAbout.Controls.Add(this.picAbout);
            this.grpAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAbout.Location = new System.Drawing.Point(3, 3);
            this.grpAbout.Name = "grpAbout";
            this.grpAbout.Size = new System.Drawing.Size(850, 459);
            this.grpAbout.TabIndex = 0;
            this.grpAbout.TabStop = false;
            this.grpAbout.Text = "About:";
            // 
            // grpAboutChild
            // 
            this.grpAboutChild.Controls.Add(this.txtReadME);
            this.grpAboutChild.Location = new System.Drawing.Point(6, 305);
            this.grpAboutChild.Name = "grpAboutChild";
            this.grpAboutChild.Size = new System.Drawing.Size(841, 148);
            this.grpAboutChild.TabIndex = 1;
            this.grpAboutChild.TabStop = false;
            this.grpAboutChild.Text = "Read ME:";
            // 
            // txtReadME
            // 
            this.txtReadME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReadME.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadME.Location = new System.Drawing.Point(3, 16);
            this.txtReadME.Name = "txtReadME";
            this.txtReadME.Size = new System.Drawing.Size(835, 129);
            this.txtReadME.TabIndex = 0;
            this.txtReadME.Text = "";
            this.txtReadME.ZoomFactor = 1.5F;
            // 
            // picAbout
            // 
            this.picAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAbout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAbout.Location = new System.Drawing.Point(280, 19);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(280, 280);
            this.picAbout.TabIndex = 0;
            this.picAbout.TabStop = false;
            this.picAbout.Click += new System.EventHandler(this.picAbout_Click);
            // 
            // tProject
            // 
            this.tProject.Controls.Add(this.grp);
            this.tProject.Controls.Add(this.grpDetails);
            this.tProject.Controls.Add(this.tsProject);
            this.tProject.Location = new System.Drawing.Point(4, 4);
            this.tProject.Name = "tProject";
            this.tProject.Padding = new System.Windows.Forms.Padding(3);
            this.tProject.Size = new System.Drawing.Size(856, 465);
            this.tProject.TabIndex = 2;
            this.tProject.Text = "Project";
            this.tProject.UseVisualStyleBackColor = true;
            // 
            // grp
            // 
            this.grp.Location = new System.Drawing.Point(438, 31);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(415, 417);
            this.grp.TabIndex = 2;
            this.grp.TabStop = false;
            this.grp.Text = "zz";
            // 
            // grpDetails
            // 
            this.grpDetails.Location = new System.Drawing.Point(3, 31);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(414, 417);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details:";
            // 
            // tsProject
            // 
            this.tsProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnEdit,
            this.btnView});
            this.tsProject.Location = new System.Drawing.Point(3, 3);
            this.tsProject.Name = "tsProject";
            this.tsProject.Size = new System.Drawing.Size(850, 25);
            this.tsProject.TabIndex = 0;
            this.tsProject.Text = "Project";
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem});
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(44, 22);
            this.btnNew.Text = "New";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 22);
            this.btnEdit.Text = "Edit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.editToolStripMenuItem.Text = "Edit {}";
            // 
            // btnView
            // 
            this.btnView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(45, 22);
            this.btnView.Text = "View";
            // 
            // tPreferences
            // 
            this.tPreferences.Controls.Add(this.grpSettings);
            this.tPreferences.Location = new System.Drawing.Point(4, 4);
            this.tPreferences.Name = "tPreferences";
            this.tPreferences.Padding = new System.Windows.Forms.Padding(3);
            this.tPreferences.Size = new System.Drawing.Size(856, 465);
            this.tPreferences.TabIndex = 1;
            this.tPreferences.Text = "Preferences";
            this.tPreferences.UseVisualStyleBackColor = true;
            // 
            // grpSettings
            // 
            this.grpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSettings.Location = new System.Drawing.Point(3, 3);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(850, 459);
            this.grpSettings.TabIndex = 0;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Preferences:";
            // 
            // tGitHub
            // 
            this.tGitHub.Controls.Add(this.grpGitHub);
            this.tGitHub.Location = new System.Drawing.Point(4, 4);
            this.tGitHub.Name = "tGitHub";
            this.tGitHub.Padding = new System.Windows.Forms.Padding(3);
            this.tGitHub.Size = new System.Drawing.Size(856, 465);
            this.tGitHub.TabIndex = 3;
            this.tGitHub.Text = "GitHub";
            this.tGitHub.UseVisualStyleBackColor = true;
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
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 491);
            this.Controls.Add(this.pnlMain);
            this.MinimumSize = new System.Drawing.Size(880, 530);
            this.Name = "FrmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.SizeChanged += new System.EventHandler(this.FrmSettings_SizeChanged);
            this.pnlMain.ResumeLayout(false);
            this.tMain.ResumeLayout(false);
            this.tAbout.ResumeLayout(false);
            this.grpAbout.ResumeLayout(false);
            this.grpAboutChild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            this.tProject.ResumeLayout(false);
            this.tProject.PerformLayout();
            this.tsProject.ResumeLayout(false);
            this.tsProject.PerformLayout();
            this.tPreferences.ResumeLayout(false);
            this.tGitHub.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabPage tPreferences;
        private System.Windows.Forms.TabPage tProject;
        private System.Windows.Forms.TabPage tGitHub;
        private System.Windows.Forms.TabPage tAbout;
        internal System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.GroupBox grpGitHub;
        internal System.Windows.Forms.GroupBox grpAbout;
        internal System.Windows.Forms.GroupBox grpAboutChild;
        internal System.Windows.Forms.TabControl tMain;
        internal System.Windows.Forms.RichTextBox txtReadME;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.ToolStrip tsProject;
        private System.Windows.Forms.ToolStripDropDownButton btnNew;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton btnEdit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton btnView;
    }
}