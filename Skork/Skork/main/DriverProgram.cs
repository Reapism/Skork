using System;
using System.Windows.Forms;

namespace Skork {

    static class DriverProgram {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSkork());           
        }
    }
}
