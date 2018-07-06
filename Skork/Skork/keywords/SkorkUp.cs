using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skork.keywords {
    class SkorkUp {

        public void up(SkorkSprite s, int x = 1) {
            if (s.Location.Y + 1 < 0 && x > 0) {
                s.Location = new Point(s.Location.X, s.Location.Y + 1);
                System.Windows.Forms.MessageBox.Show("UP " + x);
                up(s, --x);
            } else { return; }
        }
    }
}
