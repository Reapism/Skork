using System;
using System.Windows.Forms;

namespace Skork.frm {
    public partial class FrmDebug : Form {
        public FrmDebug() {
            InitializeComponent();
        }

        private void FrmDebug_Load(object sender, EventArgs e) {
            this.Icon = Properties.Resources.skork_icon;
            
        }
    }
}
