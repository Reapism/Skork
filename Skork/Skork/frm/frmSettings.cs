using System;
using System.Drawing;
using System.Windows.Forms;
using Skork.util;
using System.IO;
using System.Reflection;

namespace Skork.frm {
    public partial class FrmSettings : Form {

        public FrmSettings() {      
            InitializeComponent();
            
        }

        private void FrmSettings_Load(object sender, EventArgs e) {
            Util u = new Util();
            DownloadPicture d = new DownloadPicture();

            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ui\github_attr.txt");
            MessageBox.Show(getInfo(path, "bio"));
            txtReadME.AppendText(u.getString(u.getFile("https://raw.githubusercontent.com/Reapism/Skork/master/README.md")));
            picAbout.BackgroundImage = d.downloadImage("https://www.freeiconspng.com/uploads/beach-png-6.png");            
        }

        private void drawSettings(int index) {
            if (index == 1) {
                int xf = Width, yf = Height;
                int xp = picAbout.Width, yp = picAbout.Height;

                picAbout.Location = new Point(xf / 2 - xp / 2, 25);

            }
        }

        private string getInfo(string path, string info = "bio") {
            Util u = new Util();
            string file = u.readFile(path);
            MessageBox.Show(info);
            switch (info.ToLower()) {
                case "bio":
                    return (u.readUntil(file, 'b', '>'));
                case "project":

                case "contributions":
                    
                default:
                    return null;

            }

            //return (u.readBetween(u.readFile(path),'<','>'));
        }

        private void picAbout_Click(object sender, EventArgs e) {
            
          

        }
    }
}
