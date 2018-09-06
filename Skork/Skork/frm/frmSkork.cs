using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Collections.Specialized;
using Skork.ui;
using Skork.util;
using Skork.frm;
using System.Collections.Generic;

namespace Skork {

    public partial class frmSkork : Form {

        /// <summary>
        /// Default constructor
        /// </summary>

        public frmSkork() {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            Point frmSize = new Point(750, 500);
            this.Width = frmSize.X;
            this.Height = frmSize.Y;

            UserInterface.drawMain(this, ref frmSize);
            OutlineBox o = new OutlineBox(ref picSyntax, null, 3);
        }

        /// <summary>
        /// Perform various tasks when the load event is invoked
        /// (When the initialize component or the constructor is finished.).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frmSkork_Load(object sender, EventArgs e) {
            addHandlers();
            addToLoad();
            startText();
        }

        /// <summary>
        /// All dynamic event handlers.
        /// </summary>

        private void addHandlers() {
            lblZoom.MouseDown += lblZoom_MouseDown;
            ctxZoomFactor.ItemClicked += ctxZoomFactor_ItemClicked;
        }

        private void addToLoad() {           
            this.Icon = Properties.Resources.skork_icon;
            new SkorkToolStripRender(ref tsMain);
        }

        private void startText() {
            string v = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = "Skork Application - " + v;
            this.txtCode.Clear();
            this.txtCode.AppendText(
                "/**\n" +
                "Skork v: " + v + '\n' +
                "@author iReapism\n" +
                "*/\n\n");
        }

        private void frmSkork_Resize(object sender, EventArgs e) {
            Point p = new Point(this.Width, this.Height);
            UserInterface.drawMain(this, ref p);
        }

        public void appendText(string text, Color color, bool addNewLine = false) {
            txtCode.SuspendLayout();
            txtCode.SelectionColor = color;
            txtCode.AppendText(addNewLine ? $"{text}{Environment.NewLine}" : "\\");
            txtCode.ScrollToCaret();
            txtCode.ResumeLayout();
        }

        private void txtCode_TextChanged(object sender, EventArgs e) {
            updateZoomFactor();
            
        }

        private void updateZoomFactor() {
            lblZoom.Text = txtCode.ZoomFactor * 100 + "%";
        }

        /// <summary>
        /// As long as each button child in the Parent ContextMenuStrip 
        /// has a psuedo float tag where 1 = 1.0, this will find it and
        /// convert it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ctxZoomFactor_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

            if (e.ClickedItem is ToolStripItem) {
                ToolStripMenuItem zoom = (ToolStripMenuItem)e.ClickedItem;
                Diag d = new Diag();
                try {
                    if (zoom.Tag.ToString() == null) {
                        return;
                    } else {
                        if (zoom.HasDropDownItems) {
                            foreach (ToolStripMenuItem i in zoom.DropDownItems) {
                                if (i.Tag.ToString().Contains('.')) {
                                    float zmFct = float.Parse(i.Tag.ToString());
                                    txtCode.ZoomFactor = zmFct;
                                    updateZoomFactor();
                                }
                            }
                        }

                        if (zoom.Tag.ToString().Contains('.')) {
                            float zmFct = float.Parse(zoom.Tag.ToString());
                            txtCode.ZoomFactor = zmFct;
                            updateZoomFactor();
                        } else if (zoom.Tag.ToString().ToLower() == "custom") {
                            string s = "Enter a custom amount.:";
                            if (d.showInputDialog(s,"Skork").Equals(DialogResult.OK)) {

                            }
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Show the ctxZoomFactor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void lblZoom_MouseDown(object sender, MouseEventArgs e) {
            if (sender is ToolStripStatusLabel) {
                ToolStripStatusLabel lbl = (ToolStripStatusLabel)sender;
                // sender = (Label) sender; // explicit cast 
                ctxZoomFactor.Show(this, stsMain.Location.X, stsMain.Location.Y + stsMain.Height);
                //lbl.ForeColor = Color.Red;
            }
            updateZoomFactor();
        }

        /// <summary>
        /// While Ctrl + Scrolling, this will ensure the update of the
        /// zoom factor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtCode_MouseHover(object sender, EventArgs e) {
            updateZoomFactor();
        }

        private void btnCTXCompile_Click(object sender, EventArgs e) {
            new OutlineBox(ref picSyntax, Color.Green, 3);
            new SkorkCompile(txtCode.Text).compile();

        }

        private void btnCTXCompileDebug_Click(object sender, EventArgs e) {
            new OutlineBox(ref picSyntax, Color.Red, 3);

            Type[] args = SkorkInstructions.ints.GetType().GetGenericArguments();
            Type keyType = args[0];
            Type valueType = args[1];

            MessageBox.Show(keyType.ToString());
            MessageBox.Show(valueType.ToString());
            MessageBox.Show(valueType.IsPrimitive.ToString());

        }

        private void btnCTXSave_Click(object sender, EventArgs e) {
            new OutlineBox(ref picSyntax, null, 3);
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            new FrmSettings("Preferences").Show(this);
        }

        private void btnRedrawGrid_Click(object sender, EventArgs e) {
            SkorkPlane p = new SkorkPlane();
            p.drawPlane(ref pnlPlane, 4);
        }

        private void btnHelp_Click(object sender, EventArgs e) {

        }

        private void getLiensToolStripMenuItem_Click(object sender, EventArgs e) {
            StringCollection sc = new Util().getLines(txtCode.Text);
            foreach(string line in sc) {
                MessageBox.Show(line);
            }

        }

        private void validIdentiferToolStripMenuItem_Click(object sender, EventArgs e) {
            SkorkInstructions si = new SkorkInstructions();
            Diag d = new Diag();

            si.createKey(d.showInputDialog("Enter a variable"),
                (int.Parse(d.showInputDialog("Enter a int value",""))));


            si.temp();
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e) {
            new FrmSettings("Project").Show(this);

        }

        /// <summary>
        /// Copying text and storing it in the clipboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCopy_Click(object sender, EventArgs e) {
            this.txtCode.Copy();
            new OutlineBox(ref picSyntax, Color.Red, 3);
        }

        /// <summary>
        /// Pasting text from the clipboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnPaste_Click(object sender, EventArgs e) {
            this.txtCode.Paste();
            new OutlineBox(ref picSyntax, Color.SandyBrown, 3);
        }

        private void btnSelectAll_Click(object sender, EventArgs e) {
            this.txtCode.SelectAll();
            new OutlineBox(ref picSyntax, Color.Gold, 3);
        }

        private void btnCut_Click(object sender, EventArgs e) {
            this.txtCode.Cut();
            new OutlineBox(ref picSyntax, Color.LightSalmon, 3);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            SendKeys.Send("\b");
            new OutlineBox(ref picSyntax, Color.Red, 3);
        }

        private void btnUndo_Click(object sender, EventArgs e) {
            this.txtCode.Undo();
            new OutlineBox(ref picSyntax, Color.Blue, 3);
        }

        private void btnRedo_Click(object sender, EventArgs e) {
            this.txtCode.Redo();
            new OutlineBox(ref picSyntax, Color.Aqua, 3);
        }

        private void btnFind_Click(object sender, EventArgs e) {
            int found = this.txtCode.Find(new Diag().showInputDialog("Enter the text you want to find.", "Find"));
            if (found != -1) {
                this.txtCode.SelectionStart = found;

            } else {

            }
        }

        private void btnFindRepl_Click(object sender, EventArgs e) {
            string input = new Diag().showInputDialog("Enter the text you want to find.",
                "Find && Replace");
            string repl = new Diag().showInputDialog("Enter the text you want to replace.",
                "Find && Replace");
            while (this.txtCode.Find(input, RichTextBoxFinds.None) != -1) {

                this.txtCode.Text.Replace(input, repl);
                this.txtCode.SelectionStart = this.txtCode.SelectionStart + input.Length;
                new OutlineBox(ref picSyntax, Color.Green, 5);
            }
            new OutlineBox(ref picSyntax, Color.Red, 5);
        }

        private void btnPref_Click(object sender, EventArgs e) {
            new FrmSettings("Preferences").Show(this);
        }
    }
}