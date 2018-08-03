using System;
using System.Windows.Forms;

namespace Skork.frm {
    public partial class FrmUpdate : Form {
        public FrmUpdate() {
            InitializeComponent();
        }

        private void FrmUpdate_Load(object sender, EventArgs e) {
            this.Icon = Properties.Resources.skork_icon;
        }
    }
}
