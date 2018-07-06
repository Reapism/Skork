using System.Drawing;
using System.Windows.Forms;

namespace Skork.keywords {

    /// <summary>
    /// Represents a sprite instance. 
    /// Every sprite has these properties
    /// and can be modified depending on the
    /// scenario.
    /// </summary>

    class SkorkSprite : SkorkKeywords {
        
        protected PictureBox sprite;

        public SkorkSprite() {         
            this.sprite = new PictureBox();
            this.sprite.Location = new Point(0, 0);
            this.sprite.BackColor = Color.Blue;
        }

        public Point Location {
            get {
                return this.sprite.Location;
            }
            set {
                this.sprite.Location = value; // value is keyword for the right part of assignment
            }
        }

        public Point getLocation() {
            return this.sprite.Location;
        }



    }
}
