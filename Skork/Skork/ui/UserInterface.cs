using System.Drawing;
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
        /// <param name="p">f's size as point reference.</param>

        public static void drawMain(frmSkork f, ref Point p) {
            int xSpace = 10; // Space between group boxes
            int ySpace = 90; // Space for the height
            
            f.grpCode.Width = (p.X / 2) - xSpace;
            f.grpOutput.Width  = (p.X / 2);
            f.grpCode.Height = (p.Y - ySpace);
            f.grpOutput.Height = (p.Y - ySpace);
           
            f.picSyntax.Dock = DockStyle.Fill;

            const int outline = 5; // outline in pixels between txtCode and picSyntax
            f.txtCode.Size = new Size(f.picSyntax.Size.Width - outline, f.picSyntax.Size.Height - outline);
            f.txtCode.Location = new Point(f.picSyntax.Location.X + outline / 2, f.picSyntax.Location.Y + outline / 2);
            f.picSyntax.BackColor = Color.Green;

            
            
        }       

    }
}
