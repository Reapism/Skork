using System.Drawing;
using System.Windows.Forms;

namespace Skork.keywords {

    /// <summary>
    /// Represents a sprite instance. 
    /// Every sprite has these properties
    /// and can be modified depending on the
    /// scenario.
    /// </summary>

     class SkorkSprite : SkorkKeywords{

        protected PictureBox sprite;

        public SkorkSprite() {
            sprite = new PictureBox();
            sprite.Location = new Point(0, 0);
            sprite.BackColor = Color.Blue;
        }

        protected Point getLocation() {
            return sprite.Location;
        }



    }
}
