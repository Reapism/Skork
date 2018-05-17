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

namespace Skork {

    public partial class frmSkork : Form {
        internal decimal d;

        /// <summary>
        /// Default constructor
        /// </summary>

        public frmSkork() {
            InitializeComponent();

            Point frmSize = new Point(750, 500);
            this.Width = frmSize.X;
            this.Height = frmSize.Y;
                      
            UserInterface.drawMain(this, ref frmSize);
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
                ToolStripItem btn = e.ClickedItem;
                try {
                    if (e.ClickedItem.Tag.ToString() == null) {
                        return;
                    } else {
                        if (e.ClickedItem.Tag.ToString().Contains('.')) {
                            float zmFct = float.Parse(e.ClickedItem.Tag.ToString());
                            txtCode.ZoomFactor = zmFct;
                            updateZoomFactor();
                        } else {
                            // implement gen and custome here maybe using wildcards
                            // https://stackoverflow.com/questions/30299671/matching-strings-with-wildcard
                            // or by executing another method that finds it
                        }

                    }
                } catch (Exception ex) {
                    MessageBox.Show("Null Reference Exception", ex.Source);
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
    }
}
