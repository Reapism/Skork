using System.Drawing;
using System.Windows.Forms;

namespace Skork.keywords {

    /// <summary>
    /// Represents a sprite instance. 
    /// Every sprite has these properties
    /// and can be modified depending on the
    /// scenario.
    /// </summary>

    class SkorkSprite : SkorkKeyword {

        protected PictureBox sprite;
        protected string name;

        /// <summary>
        /// Default constructor for creating
        /// a sprite.
        /// </summary>
        /// <param name="name">The name of the sprite.</param>

        public SkorkSprite(string name) {
            this.sprite = new PictureBox {
                Location = new Point(0, 0),
                BackColor = Color.Blue
            };
            this.name = name;
        }

        /// <summary>
        /// The location of the sprite.
        /// </summary>

        public Point Location {
            get {
                return this.sprite.Location;
            }
            set {
                this.sprite.Location = value; // value is keyword for the right part of assignment
            }
        }

        public Point GetLocation() {
            return this.sprite.Location;
        }

        public override string ToString() {
            return this.name + " is a " +
                this.sprite.BackColor + " sprite at " +
                this.sprite.Location.ToString();
        }

    }
}
