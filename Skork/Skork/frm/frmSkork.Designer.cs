﻿namespace Skork
{
    partial class FrmSkork
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSkork));
            this.grpCode = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.ctxCode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCTXCompile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCTXCompileDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCTXSave = new System.Windows.Forms.ToolStripMenuItem();
            this.getLiensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validIdentiferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picSyntax = new System.Windows.Forms.PictureBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.pnlPlane = new System.Windows.Forms.Panel();
            this.ctxOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRedrawGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.addKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.lblZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.newProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.openProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.closeProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.saveProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFind = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFindRepl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPref = new System.Windows.Forms.ToolStripMenuItem();
            this.btnView = new System.Windows.Forms.ToolStripDropDownButton();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.gitHubWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.ctxZoomFactor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn100 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn110 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn125 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn150 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn200 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn250 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn300 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn400 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn500 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCustomZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.checkIntTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCode.SuspendLayout();
            this.ctxCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSyntax)).BeginInit();
            this.grpOutput.SuspendLayout();
            this.ctxOutput.SuspendLayout();
            this.stsMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.ctxZoomFactor.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCode
            // 
            this.grpCode.Controls.Add(this.txtCode);
            this.grpCode.Controls.Add(this.picSyntax);
            this.grpCode.Location = new System.Drawing.Point(3, 3);
            this.grpCode.Name = "grpCode";
            this.grpCode.Size = new System.Drawing.Size(373, 408);
            this.grpCode.TabIndex = 1;
            this.grpCode.TabStop = false;
            this.grpCode.Text = "Code:";
            // 
            // txtCode
            // 
            this.txtCode.ContextMenuStrip = this.ctxCode;
            this.txtCode.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(6, 19);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(349, 383);
            this.txtCode.TabIndex = 1;
            this.txtCode.Text = "/**\nSkork - v\n@author iReapism\n*/";
            this.txtCode.ZoomFactor = 1.5F;
            this.txtCode.TextChanged += new System.EventHandler(this.TxtCode_TextChanged);
            this.txtCode.MouseHover += new System.EventHandler(this.TxtCode_MouseHover);
            // 
            // ctxCode
            // 
            this.ctxCode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCTXCompile,
            this.btnCTXCompileDebug,
            this.btnCTXSave,
            this.getLiensToolStripMenuItem,
            this.validIdentiferToolStripMenuItem,
            this.checkIntTypeToolStripMenuItem});
            this.ctxCode.Name = "ctxCode";
            this.ctxCode.Size = new System.Drawing.Size(181, 158);
            // 
            // btnCTXCompile
            // 
            this.btnCTXCompile.Name = "btnCTXCompile";
            this.btnCTXCompile.Size = new System.Drawing.Size(180, 22);
            this.btnCTXCompile.Text = "Compile";
            this.btnCTXCompile.Click += new System.EventHandler(this.BtnCTXCompile_Click);
            // 
            // btnCTXCompileDebug
            // 
            this.btnCTXCompileDebug.Name = "btnCTXCompileDebug";
            this.btnCTXCompileDebug.Size = new System.Drawing.Size(180, 22);
            this.btnCTXCompileDebug.Text = "Compile && Debug";
            this.btnCTXCompileDebug.Click += new System.EventHandler(this.BtnCTXCompileDebug_Click);
            // 
            // btnCTXSave
            // 
            this.btnCTXSave.Name = "btnCTXSave";
            this.btnCTXSave.Size = new System.Drawing.Size(180, 22);
            this.btnCTXSave.Text = "Save";
            this.btnCTXSave.Click += new System.EventHandler(this.BtnCTXSave_Click);
            // 
            // getLiensToolStripMenuItem
            // 
            this.getLiensToolStripMenuItem.Name = "getLiensToolStripMenuItem";
            this.getLiensToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.getLiensToolStripMenuItem.Text = "GetLines";
            this.getLiensToolStripMenuItem.Click += new System.EventHandler(this.GetLiensToolStripMenuItem_Click);
            // 
            // validIdentiferToolStripMenuItem
            // 
            this.validIdentiferToolStripMenuItem.Name = "validIdentiferToolStripMenuItem";
            this.validIdentiferToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.validIdentiferToolStripMenuItem.Text = "ValidIdentifer";
            this.validIdentiferToolStripMenuItem.Click += new System.EventHandler(this.ValidIdentiferToolStripMenuItem_Click);
            // 
            // picSyntax
            // 
            this.picSyntax.Location = new System.Drawing.Point(3, 16);
            this.picSyntax.Name = "picSyntax";
            this.picSyntax.Size = new System.Drawing.Size(355, 386);
            this.picSyntax.TabIndex = 0;
            this.picSyntax.TabStop = false;
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.pnlPlane);
            this.grpOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpOutput.Location = new System.Drawing.Point(382, 3);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(349, 408);
            this.grpOutput.TabIndex = 2;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output:";
            // 
            // pnlPlane
            // 
            this.pnlPlane.ContextMenuStrip = this.ctxOutput;
            this.pnlPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlane.Location = new System.Drawing.Point(3, 16);
            this.pnlPlane.Name = "pnlPlane";
            this.pnlPlane.Size = new System.Drawing.Size(343, 389);
            this.pnlPlane.TabIndex = 0;
            // 
            // ctxOutput
            // 
            this.ctxOutput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRedrawGrid,
            this.addKeyToolStripMenuItem,
            this.listKeyToolStripMenuItem});
            this.ctxOutput.Name = "ctxOutput";
            this.ctxOutput.Size = new System.Drawing.Size(147, 70);
            // 
            // btnRedrawGrid
            // 
            this.btnRedrawGrid.Name = "btnRedrawGrid";
            this.btnRedrawGrid.Size = new System.Drawing.Size(146, 22);
            this.btnRedrawGrid.Text = "Redraw grid...";
            this.btnRedrawGrid.Click += new System.EventHandler(this.BtnRedrawGrid_Click);
            // 
            // addKeyToolStripMenuItem
            // 
            this.addKeyToolStripMenuItem.Name = "addKeyToolStripMenuItem";
            this.addKeyToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addKeyToolStripMenuItem.Text = "Add Key";
            // 
            // listKeyToolStripMenuItem
            // 
            this.listKeyToolStripMenuItem.Name = "listKeyToolStripMenuItem";
            this.listKeyToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.listKeyToolStripMenuItem.Text = "List Key";
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblZoom});
            this.stsMain.Location = new System.Drawing.Point(0, 439);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(734, 22);
            this.stsMain.TabIndex = 3;
            this.stsMain.Text = "statusStrip1";
            // 
            // lblZoom
            // 
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(35, 17);
            this.lblZoom.Text = "100%";
            // 
            // tsMain
            // 
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile,
            this.btnEdit,
            this.btnView,
            this.btnHelp,
            this.btnSettings});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(734, 25);
            this.tsMain.TabIndex = 4;
            this.tsMain.Text = "toolStrip1";
            // 
            // btnFile
            // 
            this.btnFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProfileToolStripMenuItem,
            this.newProjectToolStripMenuItem,
            this.toolStripSeparator4,
            this.openProfileToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.toolStripSeparator5,
            this.closeProfileToolStripMenuItem,
            this.closeProjectToolStripMenuItem,
            this.toolStripSeparator6,
            this.saveProfileToolStripMenuItem,
            this.loadProfileToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.saveAllProjectToolStripMenuItem,
            this.toolStripSeparator7,
            this.exitToolStripMenuItem});
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(44, 22);
            this.btnFile.Text = "  File";
            // 
            // newProfileToolStripMenuItem
            // 
            this.newProfileToolStripMenuItem.Name = "newProfileToolStripMenuItem";
            this.newProfileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.newProfileToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newProfileToolStripMenuItem.Text = "New Profile";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.NewProjectToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(183, 6);
            // 
            // openProfileToolStripMenuItem
            // 
            this.openProfileToolStripMenuItem.Name = "openProfileToolStripMenuItem";
            this.openProfileToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openProfileToolStripMenuItem.Text = "Open Profile";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(183, 6);
            // 
            // closeProfileToolStripMenuItem
            // 
            this.closeProfileToolStripMenuItem.Name = "closeProfileToolStripMenuItem";
            this.closeProfileToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.closeProfileToolStripMenuItem.Text = "Close Profile";
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.closeProjectToolStripMenuItem.Text = "Close Project";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(183, 6);
            // 
            // saveProfileToolStripMenuItem
            // 
            this.saveProfileToolStripMenuItem.Name = "saveProfileToolStripMenuItem";
            this.saveProfileToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveProfileToolStripMenuItem.Text = "Save Profile";
            // 
            // loadProfileToolStripMenuItem
            // 
            this.loadProfileToolStripMenuItem.Name = "loadProfileToolStripMenuItem";
            this.loadProfileToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.loadProfileToolStripMenuItem.Text = "Reload Profile";
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            // 
            // saveAllProjectToolStripMenuItem
            // 
            this.saveAllProjectToolStripMenuItem.Name = "saveAllProjectToolStripMenuItem";
            this.saveAllProjectToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAllProjectToolStripMenuItem.Text = "Save All Project";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUndo,
            this.btnRedo,
            this.toolStripSeparator1,
            this.btnCut,
            this.btnCopy,
            this.btnPaste,
            this.btnDelete,
            this.btnSelectAll,
            this.toolStripSeparator2,
            this.btnFind,
            this.btnFindRepl,
            this.toolStripSeparator3,
            this.btnPref});
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(46, 22);
            this.btnEdit.Text = "  Edit";
            // 
            // btnUndo
            // 
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.btnUndo.Size = new System.Drawing.Size(226, 22);
            this.btnUndo.Text = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.btnRedo.Size = new System.Drawing.Size(226, 22);
            this.btnRedo.Text = "Redo";
            this.btnRedo.Click += new System.EventHandler(this.BtnRedo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // btnCut
            // 
            this.btnCut.Name = "btnCut";
            this.btnCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.btnCut.Size = new System.Drawing.Size(226, 22);
            this.btnCut.Text = "Cut";
            this.btnCut.Click += new System.EventHandler(this.BtnCut_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.btnCopy.Size = new System.Drawing.Size(226, 22);
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.btnPaste.Size = new System.Drawing.Size(226, 22);
            this.btnPaste.Text = "Paste";
            this.btnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.btnDelete.Size = new System.Drawing.Size(226, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.btnSelectAll.Size = new System.Drawing.Size(226, 22);
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.Click += new System.EventHandler(this.BtnSelectAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(223, 6);
            // 
            // btnFind
            // 
            this.btnFind.Name = "btnFind";
            this.btnFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.btnFind.Size = new System.Drawing.Size(226, 22);
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // btnFindRepl
            // 
            this.btnFindRepl.Name = "btnFindRepl";
            this.btnFindRepl.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.btnFindRepl.Size = new System.Drawing.Size(226, 22);
            this.btnFindRepl.Text = "Find && Replace";
            this.btnFindRepl.Click += new System.EventHandler(this.BtnFindRepl_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(223, 6);
            // 
            // btnPref
            // 
            this.btnPref.Name = "btnPref";
            this.btnPref.Size = new System.Drawing.Size(226, 22);
            this.btnPref.Text = "Preferences";
            this.btnPref.Click += new System.EventHandler(this.BtnPref_Click);
            // 
            // btnView
            // 
            this.btnView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugToolStripMenuItem});
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(51, 22);
            this.btnView.Text = "  View";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubWikiToolStripMenuItem,
            this.youTubeToolStripMenuItem});
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(51, 22);
            this.btnHelp.Text = "  Help";
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // gitHubWikiToolStripMenuItem
            // 
            this.gitHubWikiToolStripMenuItem.Name = "gitHubWikiToolStripMenuItem";
            this.gitHubWikiToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.gitHubWikiToolStripMenuItem.Text = "GitHub Wiki";
            // 
            // youTubeToolStripMenuItem
            // 
            this.youTubeToolStripMenuItem.Name = "youTubeToolStripMenuItem";
            this.youTubeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.youTubeToolStripMenuItem.Text = "YouTube";
            // 
            // btnSettings
            // 
            this.btnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(23, 22);
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // ctxZoomFactor
            // 
            this.ctxZoomFactor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn100,
            this.btn110,
            this.btn125,
            this.btn150,
            this.btn200,
            this.btn250,
            this.btn300,
            this.btn400,
            this.btn500,
            this.btnCustomZoom});
            this.ctxZoomFactor.Name = "ctxZoomFactor";
            this.ctxZoomFactor.Size = new System.Drawing.Size(126, 224);
            // 
            // btn100
            // 
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(125, 22);
            this.btn100.Tag = "1.0";
            this.btn100.Text = "100%";
            // 
            // btn110
            // 
            this.btn110.Name = "btn110";
            this.btn110.Size = new System.Drawing.Size(125, 22);
            this.btn110.Tag = "1.1";
            this.btn110.Text = "110%";
            // 
            // btn125
            // 
            this.btn125.Name = "btn125";
            this.btn125.Size = new System.Drawing.Size(125, 22);
            this.btn125.Tag = "1.25";
            this.btn125.Text = "125%";
            // 
            // btn150
            // 
            this.btn150.Name = "btn150";
            this.btn150.Size = new System.Drawing.Size(125, 22);
            this.btn150.Tag = "1.5";
            this.btn150.Text = "150%";
            // 
            // btn200
            // 
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(125, 22);
            this.btn200.Tag = "2.0";
            this.btn200.Text = "200%";
            // 
            // btn250
            // 
            this.btn250.Name = "btn250";
            this.btn250.Size = new System.Drawing.Size(125, 22);
            this.btn250.Tag = "2.5";
            this.btn250.Text = "250%";
            // 
            // btn300
            // 
            this.btn300.Name = "btn300";
            this.btn300.Size = new System.Drawing.Size(125, 22);
            this.btn300.Tag = "3.0";
            this.btn300.Text = "300%";
            // 
            // btn400
            // 
            this.btn400.Name = "btn400";
            this.btn400.Size = new System.Drawing.Size(125, 22);
            this.btn400.Tag = "4.0";
            this.btn400.Text = "400%";
            // 
            // btn500
            // 
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(125, 22);
            this.btn500.Tag = "5.0";
            this.btn500.Text = "500%";
            // 
            // btnCustomZoom
            // 
            this.btnCustomZoom.Name = "btnCustomZoom";
            this.btnCustomZoom.Size = new System.Drawing.Size(125, 22);
            this.btnCustomZoom.Tag = "Custom";
            this.btnCustomZoom.Text = "Custom...";
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.63488F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.36512F));
            this.tblMain.Controls.Add(this.grpCode, 0, 0);
            this.tblMain.Controls.Add(this.grpOutput, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 25);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(734, 414);
            this.tblMain.TabIndex = 5;
            // 
            // checkIntTypeToolStripMenuItem
            // 
            this.checkIntTypeToolStripMenuItem.Name = "checkIntTypeToolStripMenuItem";
            this.checkIntTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkIntTypeToolStripMenuItem.Text = "Check int type";
            this.checkIntTypeToolStripMenuItem.Click += new System.EventHandler(this.checkIntTypeToolStripMenuItem_Click);
            // 
            // FrmSkork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.stsMain);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "FrmSkork";
            this.Text = "Skork Application - ";
            this.Load += new System.EventHandler(this.FrmSkork_Load);
            this.Resize += new System.EventHandler(this.FrmSkork_Resize);
            this.grpCode.ResumeLayout(false);
            this.ctxCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSyntax)).EndInit();
            this.grpOutput.ResumeLayout(false);
            this.ctxOutput.ResumeLayout(false);
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ctxZoomFactor.ResumeLayout(false);
            this.tblMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStrip tsMain;
        internal System.Windows.Forms.GroupBox grpCode;
        internal System.Windows.Forms.GroupBox grpOutput;
        internal System.Windows.Forms.RichTextBox txtCode;
        internal System.Windows.Forms.PictureBox picSyntax;
        private System.Windows.Forms.ContextMenuStrip ctxCode;
        private System.Windows.Forms.ToolStripMenuItem btnCTXCompile;
        private System.Windows.Forms.ToolStripMenuItem btnCTXCompileDebug;
        private System.Windows.Forms.ToolStripMenuItem btnCTXSave;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ContextMenuStrip ctxZoomFactor;
        private System.Windows.Forms.ToolStripMenuItem btn100;
        private System.Windows.Forms.ToolStripMenuItem btn110;
        private System.Windows.Forms.ToolStripMenuItem btn125;
        private System.Windows.Forms.ToolStripMenuItem btn150;
        private System.Windows.Forms.ToolStripMenuItem btn200;
        private System.Windows.Forms.ToolStripMenuItem btn250;
        private System.Windows.Forms.ToolStripMenuItem btn300;
        private System.Windows.Forms.ToolStripMenuItem btn400;
        private System.Windows.Forms.ToolStripMenuItem btn500;
        private System.Windows.Forms.ToolStripMenuItem btnCustomZoom;
        private System.Windows.Forms.ToolStripStatusLabel lblZoom;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Panel pnlPlane;
        private System.Windows.Forms.ContextMenuStrip ctxOutput;
        private System.Windows.Forms.ToolStripMenuItem btnRedrawGrid;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getLiensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validIdentiferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnUndo;
        private System.Windows.Forms.ToolStripMenuItem btnRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnCut;
        private System.Windows.Forms.ToolStripMenuItem btnCopy;
        private System.Windows.Forms.ToolStripMenuItem btnPaste;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnFind;
        private System.Windows.Forms.ToolStripMenuItem btnFindRepl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btnPref;
        private System.Windows.Forms.ToolStripMenuItem gitHubWikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youTubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem openProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem closeProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem saveProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripDropDownButton btnFile;
        internal System.Windows.Forms.ToolStripDropDownButton btnEdit;
        internal System.Windows.Forms.ToolStripDropDownButton btnView;
        internal System.Windows.Forms.ToolStripDropDownButton btnHelp;
        private System.Windows.Forms.ToolStripMenuItem btnSelectAll;
        private System.Windows.Forms.ToolStripMenuItem checkIntTypeToolStripMenuItem;
    }
}

