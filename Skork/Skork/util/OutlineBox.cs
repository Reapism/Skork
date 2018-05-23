using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skork.util {

    /// <summary>
    /// OutlineBox is a class that takes a picturebox
    /// and flicker it a certain color n times.
    /// <para>- Call member function outlineControl(PictureBox,
    /// byte = [], byte = []) to invoke the process.</para>
    /// <para>+ Execution runs on a separate thread.</para>
    /// </summary>

   class OutlineBox {
        
        private byte outlineNumTimes;
        private Color outlineColor;
        private Color outlineColor2;
        private Timer outlineTimer;
        private PictureBox p;
        private byte type;
        private short interval;
        
        /// <summary>
        /// Default constructor for OutlineBox.
        /// </summary>

        public OutlineBox() {
            this.outlineNumTimes = 0;
            this.outlineColor = Color.White;
            this.outlineColor2 = Color.Transparent;
            this.outlineTimer = new Timer();
            this.p = new PictureBox();
            this.type = 0;
            this.interval = 100;
        }

        /// <summary>
        /// Destructor for instance variables.
        /// </summary>

        ~OutlineBox() {
            
        }

        /// <summary>
        /// Takes a picture box by reference, and outlines it num times.
        /// Use type parameter to specify the type
        /// </summary>
        /// <param name="p">The picturebox to outline.</param>
        /// <param name="type">The type of outline {1 = green, 2 = red, 3 = gold, type >= 4 = random}</param>
        /// <param name="num">Number of times to flicker the color.</param>

        public void outlineControl(ref PictureBox p, byte type, byte num = 3) {
            this.type = type; // copy parameter to member variable.
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

        private void outlineControl_DoWork(object sender, DoWorkEventArgs e) {

            //MessageBox.Show(e.Argument.ToString());
            if (e.Argument is PictureBox) {
                this.p = (PictureBox) e.Argument;              
                if (this.type == 1) {
                    outlineColor = Color.Green;
                } else if (this.type == 2) {
                    outlineColor = Color.IndianRed;
                } else if (this.type == 3) {
                    outlineColor = Color.Gold;
                } else {
                    Random rnd = new Random();
                    outlineColor = Color.FromArgb(255, rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
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
