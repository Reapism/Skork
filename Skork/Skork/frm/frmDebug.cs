using System;
using System.Windows.Forms;

namespace Skork.frm {
    public partial class frmDebug : Form {
        public frmDebug() {
            InitializeComponent();
        }

        private void frmDebug_Load(object sender, EventArgs e) {
            this.Icon = Properties.Resources.skork_icon;
            
        }
    }
}
