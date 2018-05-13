using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skork.util;

namespace Skork {

    public partial class frmSkork : Form {
        internal decimal d;
        public frmSkork() {
            Point frmSize = new Point(750, 500);
            InitializeComponent();
            this.Width = frmSize.X;
            this.Height = frmSize.Y;
            UserInterface.drawMain(this, ref frmSize);
        }

        private void frmSkork_Load(object sender, EventArgs e) {
        }
    }
}
