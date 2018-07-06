using System.Drawing;

namespace Skork.keywords {

    class SkorkLeft {

        /// <summary>
        /// Moves a sprite left by default one unit.
        /// <para>Recursively calls itself if X > 1</para>
        /// </summary>
        /// <param name="s">The sprite to move.</param>
        /// <param name="x">Moves the sprite x times left.</param>

        public void left(SkorkSprite s, int x = 1) {
            if (s.Location.X - 1 < 0 && x > 0) {
                s.Location = new Point(s.Location.X - 1, s.Location.Y);
                System.Windows.Forms.MessageBox.Show("LEFT " + x);
                left(s, --x);
            } else { return; }
        }
    }
}


