using System;
using System.Drawing;
using System.Windows.Forms;

namespace Skork.ui {
    class SkorkPlane {

        private int numX;
        private int numY;

        public SkorkPlane() {
            this.numX = 0;
            this.numY = 0;
        }

        /// <summary>
        /// Draws a grid onto a new Bitmap image and returns it.
        /// </summary>
        /// <param name="width">The width of the picture.</param>
        /// <param name="height">The height of the picture.</param>
        /// <param name="sizeOfPixel">The size of each coordinate box.</param>
        /// <returns>A bitmap image of a grind</returns>

        public Bitmap DrawGrid(int width, int height, int sizeOfPixel) {
            Bitmap b = new Bitmap(width, height);
            int x, y;

            for (y = 0; y < height; y += sizeOfPixel) {
                x = 0;

                for (x = 0; x < width; x += 1) {
                    if (!(x + sizeOfPixel > width) || (x < width + sizeOfPixel)) {
                        b.SetPixel(x, y, Color.White);
                    }
                }
            }

            for (x = 0; x < width; x += sizeOfPixel) {
                y = 0;

                for (y = 0; y < height; y += 1) {
                    if (!(y + sizeOfPixel > height) || (y < height + sizeOfPixel)) {
                        b.SetPixel(x, y, Color.White);
                    }
                }
            }

            return b;
        }

        public void DrawPlane(ref Panel plane, int i) {

            foreach (object item in plane.Controls) {
                if (item is PictureBox p) {
                    p.Dispose();
                }
            }

            Image img = DrawGrid(plane.Width, plane.Height, i);

            PictureBox pic = new PictureBox {
                BackgroundImage = img,
                BackColor = Color.Black,
                BackgroundImageLayout = ImageLayout.Stretch,
            };

            plane.Controls.Add(pic);
            pic.Dock = DockStyle.Fill;
        }

        [Obsolete("DrawPlane(ref Panel) is deprecated, please use drawPlane(ref Panel, int) instead.", true)]
        public void DrawPlane(ref Panel plane) {

            plane.Controls.Clear();
            this.numX = 0;
            this.numY = 0;

            Random rnd = new Random();
            Size sz = plane.Size;
            Point temp = new Point(0, 0);
            const int sizeUnit = 4; // 4 pixels wide           
            int x = 0;

            for (int y = 0; y < sz.Height; y += sizeUnit * sizeUnit) {
                temp.X = 0;
                this.numY++;

                for (x = 0; x < sz.Width; x += sizeUnit * (sizeUnit / 2)) {

                    if (x + temp.X < sz.Width) {
                        PictureBox unit = new PictureBox();
                        rnd = new Random(rnd.Next());

                        unit.Size = new Size(sizeUnit * sizeUnit, sizeUnit * sizeUnit);
                        unit.Location = new Point(x + temp.X, y + temp.Y);
                        unit.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255));
                        unit.Click += Unit_Click;
                        plane.Controls.Add(unit);
                        temp.X += sizeUnit * 2;
                        temp.Y = 0;
                        this.numX++;

                    } else {
                        continue;
                    }
                }
            }
            this.numX = this.numX / this.numY; // determine number of boxes on X-axis
        }

        private void Unit_Click(object sender, EventArgs e) {
            if (sender is PictureBox p) {
                MessageBox.Show(p.Location.ToString() + " = Number in x-axis " +
                    this.numX + " - number in y-axis " + this.numY);
                return;
            }
            throw new Exception("Not a picturebox for some reason. - " + sender.ToString());
        }
    }
}
