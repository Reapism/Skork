using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skork.ui {

    class UserInterface {

        /// <summary>
        /// Default constructor for UserInterface
        /// </summary>

        public UserInterface() {

        }

        /// <summary>
        /// Correctly splits the two groupboxes in frmSkork apart.
        /// </summary>
        /// <param name="f">A frmSkork instance</param>
        /// <param name="p">A point reference.</param>

        public static void drawMain(frmSkork f, ref Point p) {
            f.grpCode.Width = p.X / 2;
            f.grpOutput.Width  = p.X / 2;
            
            const int outline = 5;
            f.txtCode.Size = new Size(f.picSyntax.Size.Width - outline, f.picSyntax.Size.Height - outline);
            f.txtCode.Location = new Point(f.picSyntax.Location.X + outline / 2, f.picSyntax.Location.Y + outline / 2);
            f.picSyntax.BackColor = Color.Green;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="type">The type of outline {}</param>
        /// <param name="num">Number of times to flicker the color.</param>

        public static void outlineControl(ref PictureBox p, ref byte type, byte num = 1) {
            Timer t = new Timer();
            t.Interval = num * 1000;
            t.Tick += outlineControl_Tick;

            BackgroundWorker b = new BackgroundWorker();
            b.DoWork += outlineControl_DoWork;

            p.BackColor = Color.Transparent;
            t.Start();
        }

        private static void outlineControl_DoWork(object sender, DoWorkEventArgs e) {
            throw new NotImplementedException();
        }

        private static void outlineControl_Tick(object sender, EventArgs e) {
            if (sender.GetType() == typeof(frmSkork))
                MessageBox.Show("", "Sender is typeoff frmSkork");

            throw new NotImplementedException();
        }

    }
}
