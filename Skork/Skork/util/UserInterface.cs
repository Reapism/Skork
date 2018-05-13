using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skork.util {

    class UserInterface {

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
            
        }

    }
}
