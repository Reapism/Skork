using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skork.util {

    class OutlineBox {

        private byte outlineNumTimes;
        private Color outlineColor;
        private Timer outlineTimer;

        /// <summary>
        /// Default constructor for OutlineBox.
        /// </summary>

        public OutlineBox() {
            outlineNumTimes = 0;
            outlineColor = Color.White;
            outlineTimer = new Timer();
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
        /// <param name="p"></param>
        /// <param name="type">The type of outline {1 = green, 2 = red, 3 = gold, }</param>
        /// <param name="num">Number of times to flicker the color.</param>

        public void outlineControl(ref PictureBox p, byte type, byte num = 3) {
            outlineTimer.Interval = num * 333; // 1/3 a second
            outlineTimer.Tick += outlineControl_Tick;

            BackgroundWorker b = new BackgroundWorker();
            b.WorkerSupportsCancellation = true;
            b.WorkerReportsProgress = false;
            b.DoWork += outlineControl_DoWork; // add handler

            p.BackColor = Color.Transparent;
            outlineNumTimes = num;
            outlineTimer.Start();
            b.RunWorkerAsync(type); // gets passed into DoWork method as e.Argument
        }

        private void outlineControl_DoWork(object sender, DoWorkEventArgs e) {

            MessageBox.Show(e.Argument.ToString());
            if (e.Argument is byte) {
                byte type = (byte)e.Argument;

                if (type == 1) {
                    outlineColor = Color.Green;
                } else if (type == 2) {
                    outlineColor = Color.IndianRed;
                } else if (type == 3) {
                    outlineColor = Color.Gold;
                }
            } else {
                throw new NotImplementedException("Not implemented yet");
            }
        }

        private void outlineControl_Tick(object sender, EventArgs e) {
            MessageBox.Show(sender.ToString());

            if (outlineNumTimes <= 0) {

            } else {
                outlineNumTimes--;

            }

        }
    }
}
