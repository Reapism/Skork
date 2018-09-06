using System.Drawing;

namespace Skork.keywords {
    class SkorkSpriteDirection {

        public SkorkSpriteDirection() {

        }

        /// <summary>
        /// Moves a sprite down by default one unit.
        /// <para>Recursively calls itself if i > 1</para>
        /// </summary>
        /// <param name="s">The sprite to move.</param>
        /// <param name="i">Moves the sprite i times down.</param>

        public void Down(SkorkSprite s, int i = 1) {
            if (s.Location.Y - 1 < 0 && i > 0) {
                s.Location = new Point(s.Location.X, s.Location.Y - 1);
                Down(s, --i);
            } else { return; }
        }

        /// <summary>
        /// Moves a sprite left by default one unit.
        /// <para>Recursively calls itself if i > 1</para>
        /// </summary>
        /// <param name="s">The sprite to move.</param>
        /// <param name="i">Moves the sprite x times left.</param>

        public void Left(SkorkSprite s, int i = 1) {
            if (s.Location.X - 1 < 0 && i > 0) {
                s.Location = new Point(s.Location.X - 1, s.Location.Y);
                Left(s, --i);
            } else { return; }
        }

        /// <summary>
        /// Moves a sprite right by default one unit.
        /// <para>Recursively calls itself if i > 1</para>
        /// </summary>
        /// <param name="s">The sprite to move.</param>
        /// <param name="i">Moves the sprite x times right.</param>

        public void Right(SkorkSprite s, int i = 1) {
            if (s.Location.X + 1 < 0 && i > 0) {
                s.Location = new Point(s.Location.X + 1, s.Location.Y);
                Right(s, --i);
            } else { return; }
        }

        /// <summary>
        /// Moves a sprite up by default one unit.
        /// <para>Recursively calls itself if i > 1</para>
        /// </summary>
        /// <param name="s">The sprite to move.</param>
        /// <param name="i">Moves the sprite x times up.</param>

        public void Up(SkorkSprite s, int i = 1) {
            if (s.Location.Y + 1 < 0 && i > 0) {
                s.Location = new Point(s.Location.X, s.Location.Y + 1);
                Up(s, --i);
            } else { return; }
        }

    }
}
