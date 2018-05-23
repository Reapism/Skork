using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skork.ui;
using Skork.util;
using System.Reflection;
using Skork.keywords;

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
            OutlineBox o = new OutlineBox();
            o.outlineControl(ref picSyntax, 4, 3);
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
        }

        /// <summary>
        /// All dynamic event handlers.
        /// </summary>

        private void addHandlers() {
            lblZoom.MouseDown += lblZoom_MouseDown;
            ctxZoomFactor.ItemClicked += ctxZoomFactor_ItemClicked;
        }

        private void addToLoad() {
            string v = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = "Skork Application - " + v;
            this.txtCode.Text =
                "/**\n" +
                "Skork v: " + v + '\n' +
                "@author iReapism\n" +
                "*/\n";
        }

        private void frmSkork_Resize(object sender, EventArgs e) {
            Point p = new Point(this.Width, this.Height);
            UserInterface.drawMain(this, ref p);

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
                        } else {
                            if (zoom.Tag.ToString().ToLower() == "generate more") {
                                ToolStripMenuItem t = (ToolStripMenuItem)e.ClickedItem;
                                if (!t.HasDropDownItems) {
                                    genMore(ref t);
                                }
                            } else if (zoom.Tag.ToString().ToLower() == "custom") {
                                string s = "Enter a custom amount.:";
                                if (Diag.showInputDialog(ref s).Equals(DialogResult.OK)) {

                                }
                            } else {

                            }

                        }

                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void genMore(ref ToolStripMenuItem t) {
            byte step = 10;
            for (int i = 100; i < 500; i += step) {
                ToolStripMenuItem item = new ToolStripMenuItem(i + "%");
                item.Tag = i + ".0";
                t.DropDownItems.Add(item);
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
            OutlineBox o = new OutlineBox();
            o.outlineControl(ref picSyntax, 1, 3);
        }

        private void btnCTXCompileDebug_Click(object sender, EventArgs e) {
            OutlineBox o = new OutlineBox();
            o.outlineControl(ref picSyntax, 2, 3);
        }

        private void btnCTXSave_Click(object sender, EventArgs e) {
            OutlineBox o = new OutlineBox();
            o.outlineControl(ref picSyntax, 3, 3);
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e) {
            MessageBox.Show(sender.ToString());
            if (e.X > 1) {

            }
        }

        private void btnFile_Click(object sender, EventArgs e) {
            OutlineBox o = new OutlineBox();
            o.outlineControl(ref picSyntax, 3, 3);


        }

        private void getTextToolStripMenuItem_Click(object sender, EventArgs e) {
            string s = "c";
            getTextToolStripMenuItem.Text = Diag.showInputDialog(ref s, false, "s");
        }
    }
}
