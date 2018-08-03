using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Skork.util {

    /// <summary>
    /// OutlineBox is a class that takes a picturebox
    /// and flicker it a particular color num times.
    /// <para>- Construct this object with the following 
    /// parameters(PictureBox, Nullable&lt;Color&gt;,
    /// byte = []) to invoke the process.</para>
    /// <para>+ Execution runs on a separate thread.</para>
    /// </summary>

    class OutlineBox {

        private byte outlineNumTimes;
        private Color outlineColor;
        private Color outlineColor2;
        private Timer outlineTimer;
        private PictureBox p;
        private short interval;

        /// <summary>
        /// Creating a colored outline using a picturebox.
        /// </summary>
        /// <param name="p">The picturebox to perform the flicker</param>
        /// <param name="type">Nullable type. The color to flicker or null for a random color.</param>
        /// <param name="num">The number of times to flicker the picturebox.</param>

        public OutlineBox(ref PictureBox p, Color? type, byte num = 3) {
            this.outlineNumTimes = num;
            this.outlineColor = Color.White;
            this.outlineColor2 = Color.Transparent;
            this.outlineTimer = new Timer();
            this.p = new PictureBox();           
            this.interval = 100;

            if (type.HasValue) {
                this.outlineColor = (Color) type;
            } else {
                Random rnd = new Random();
                outlineColor = Color.FromArgb(255, rnd.Next(256), rnd.Next(256), rnd.Next(256));
            }            

            outlineTimer.Interval = this.interval;
            outlineTimer.Tick += outlineControl_Tick;

            BackgroundWorker b = new BackgroundWorker();
            b.WorkerSupportsCancellation = true;
            b.WorkerReportsProgress = false;
            b.DoWork += outlineControl_DoWork; // add handler

            p.BackColor = Color.Transparent;
            outlineNumTimes = num;
            outlineTimer.Start();
            b.RunWorkerAsync(p); // gets passed into DoWork method as e.Argument
        }

        /// <summary>
        /// Takes a picture box by reference, and outlines it num times [Threaded].
        /// <para>The type of outline {1 = green, 2 = red, 3 = gold, else = random color}</para>
        /// </summary>
        /// <param name="p">The picturebox to outline.</param>
        /// <param name="type">The color to pass.</param>
        /// <param name="num">Number of times to flicker the color.</param>

        private void outlineControl_DoWork(object sender, DoWorkEventArgs e) {

            if (e.Argument is PictureBox) {
                this.p = (PictureBox)e.Argument;              
            } else {
                throw new ArgumentException("Object passed is not a picturebox" + this.ToString());
            }
        }

        private void outlineControl_Tick(object sender, EventArgs e) {
            if (outlineNumTimes <= 0) {
                this.outlineTimer.Stop();
                this.p.BackColor = this.outlineColor2;
            } else {

                if (this.p.BackColor == this.outlineColor) {
                    this.p.BackColor = this.outlineColor2;
                    --this.outlineNumTimes;
                } else if (this.p.BackColor == this.outlineColor2) {
                    this.p.BackColor = this.outlineColor;
                } else {
                    return;
                }
            }
        }

    }
}
