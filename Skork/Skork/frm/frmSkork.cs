using Skork.frm;
using Skork.ui;
using Skork.util;
using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Skork {

    public partial class FrmSkork : Form {

        /// <summary>
        /// Default constructor
        /// </summary>

        public FrmSkork() {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            Point frmSize = new Point(750, 500);
            Width = frmSize.X;
            Height = frmSize.Y;

            UserInterface.DrawMain(this, ref frmSize);
            OutlineBox o = new OutlineBox(ref this.picSyntax, null, 3);
        }

        /// <summary>
        /// Perform various tasks when the load event is invoked
        /// (When the initialize component or the constructor is finished.).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FrmSkork_Load(object sender, EventArgs e) {
            AddHandlers();
            AddToLoad();
            StartText();
        }

        /// <summary>
        /// All dynamic event handlers.
        /// </summary>

        private void AddHandlers() {
            this.lblZoom.MouseDown += LblZoom_MouseDown;
            this.ctxZoomFactor.ItemClicked += CtxZoomFactor_ItemClicked;
        }

        private void AddToLoad() {
            Icon = Properties.Resources.skork_icon;
            new SkorkToolStripRender(ref this.tsMain);
        }

        private void StartText() {
            string v = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Text = "Skork Application - " + v;
            this.txtCode.Clear();
            this.txtCode.AppendText(
                "/**\n" +
                "Skork v: " + v + '\n' +
                "@author iReapism\n" +
                "*/\n\n");
        }

        private void FrmSkork_Resize(object sender, EventArgs e) {
            Point p = new Point(Width, Height);
            UserInterface.DrawMain(this, ref p);
        }

        public void AppendText(string text, Color color, bool addNewLine = false) {
            this.txtCode.SuspendLayout();
            this.txtCode.SelectionColor = color;
            this.txtCode.AppendText(addNewLine ? $"{text}{Environment.NewLine}" : "\\");
            this.txtCode.ScrollToCaret();
            this.txtCode.ResumeLayout();
        }

        private void TxtCode_TextChanged(object sender, EventArgs e) {
            UpdateZoomFactor();

        }

        private void UpdateZoomFactor() {
            this.lblZoom.Text = this.txtCode.ZoomFactor * 100 + "%";
        }

        /// <summary>
        /// As long as each button child in the Parent ContextMenuStrip 
        /// has a psuedo float tag where 1 = 1.0, this will find it and
        /// convert it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CtxZoomFactor_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

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
                                    this.txtCode.ZoomFactor = zmFct;
                                    UpdateZoomFactor();
                                }
                            }
                        }

                        if (zoom.Tag.ToString().Contains('.')) {
                            float zmFct = float.Parse(zoom.Tag.ToString());
                            this.txtCode.ZoomFactor = zmFct;
                            UpdateZoomFactor();
                        } else if (zoom.Tag.ToString().ToLower() == "custom") {
                            string s = "Enter a custom amount.:";
                            if (d.ShowInputDialog(s, "Skork").Equals(DialogResult.OK)) {

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

        private void LblZoom_MouseDown(object sender, MouseEventArgs e) {
            if (sender is ToolStripStatusLabel lbl) {
                // sender = (Label) sender; // explicit cast 
                this.ctxZoomFactor.Show(this, this.stsMain.Location.X, this.stsMain.Location.Y + this.stsMain.Height);
                //lbl.ForeColor = Color.Red;
            }
            UpdateZoomFactor();
        }

        /// <summary>
        /// While Ctrl + Scrolling, this will ensure the update of the
        /// zoom factor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void TxtCode_MouseHover(object sender, EventArgs e) {
            UpdateZoomFactor();
        }

        private void BtnCTXCompile_Click(object sender, EventArgs e) {
            Util u = new Util();

            new OutlineBox(ref this.picSyntax, Color.Green, 3);
            new SkorkCompile(u.GetLines(this.txtCode.Text));

        }

        private void BtnCTXCompileDebug_Click(object sender, EventArgs e) {
            new OutlineBox(ref this.picSyntax, Color.Red, 3);

            Type[] args = SkorkInstructions.Ints.GetType().GetGenericArguments();
            Type keyType = args[0];
            Type valueType = args[1];

            MessageBox.Show(keyType.ToString());
            MessageBox.Show(valueType.ToString());
            MessageBox.Show(valueType.IsPrimitive.ToString());

        }

        private void BtnCTXSave_Click(object sender, EventArgs e) {
            new OutlineBox(ref this.picSyntax, null, 3);
        }

        private void BtnSettings_Click(object sender, EventArgs e) {
            new FrmSettings("Preferences").Show(this);
        }

        private void BtnRedrawGrid_Click(object sender, EventArgs e) {
            SkorkPlane p = new SkorkPlane();
            p.DrawPlane(ref this.pnlPlane, 4);
        }

        private void BtnHelp_Click(object sender, EventArgs e) {

        }

        private void GetLiensToolStripMenuItem_Click(object sender, EventArgs e) {
            StringCollection sc = new Util().GetLines(this.txtCode.Text);
            foreach (string line in sc) {
                MessageBox.Show(line);
            }

        }

        private void ValidIdentiferToolStripMenuItem_Click(object sender, EventArgs e) {
            SkorkInstructions si = new SkorkInstructions();
            Diag d = new Diag();

            si.CreateKey(d.ShowInputDialog("Enter a variable"),
                (int.Parse(d.ShowInputDialog("Enter a int value", ""))));


            si.Temp();
        }

        private void NewProjectToolStripMenuItem_Click(object sender, EventArgs e) {
            new FrmSettings("Project").Show(this);

        }

        /// <summary>
        /// Copying text and storing it in the clipboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnCopy_Click(object sender, EventArgs e) {
            this.txtCode.Copy();
            new OutlineBox(ref this.picSyntax, Color.Red, 3);
        }

        /// <summary>
        /// Pasting text from the clipboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnPaste_Click(object sender, EventArgs e) {
            this.txtCode.Paste();
            new OutlineBox(ref this.picSyntax, Color.SandyBrown, 3);
        }

        private void BtnSelectAll_Click(object sender, EventArgs e) {
            this.txtCode.SelectAll();
            new OutlineBox(ref this.picSyntax, Color.Gold, 3);
        }

        private void BtnCut_Click(object sender, EventArgs e) {
            this.txtCode.Cut();
            new OutlineBox(ref this.picSyntax, Color.LightSalmon, 3);
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            SendKeys.Send("\b");
            new OutlineBox(ref this.picSyntax, Color.Red, 3);
        }

        private void BtnUndo_Click(object sender, EventArgs e) {
            this.txtCode.Undo();
            new OutlineBox(ref this.picSyntax, Color.Blue, 3);
        }

        private void BtnRedo_Click(object sender, EventArgs e) {
            this.txtCode.Redo();
            new OutlineBox(ref this.picSyntax, Color.Aqua, 3);
        }

        private void BtnFind_Click(object sender, EventArgs e) {
            int found = this.txtCode.Find(new Diag().ShowInputDialog("Enter the text you want to find.", "Find"));
            if (found != -1) {
                this.txtCode.SelectionStart = found;

            } else {

            }
        }

        private void BtnFindRepl_Click(object sender, EventArgs e) {
            string input = new Diag().ShowInputDialog("Enter the text you want to find.",
                "Find && Replace");
            string repl = new Diag().ShowInputDialog("Enter the text you want to replace.",
                "Find && Replace");
            while (this.txtCode.Find(input, RichTextBoxFinds.None) != -1) {

                this.txtCode.Text.Replace(input, repl);
                this.txtCode.SelectionStart = this.txtCode.SelectionStart + input.Length;
                new OutlineBox(ref this.picSyntax, Color.Green, 5);
            }
            new OutlineBox(ref this.picSyntax, Color.Red, 5);
        }

        private void BtnPref_Click(object sender, EventArgs e) {
            new FrmSettings("Preferences").Show(this);
        }
    }
}