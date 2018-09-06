using System;
using System.Drawing;
using System.Windows.Forms;
using Skork.util;
using System.IO;
using System.Reflection;
using System.Net;

namespace Skork.frm {
    public partial class FrmSettings : Form {

        /// <summary>
        /// Default constructor
        /// </summary>

        public FrmSettings() {
            this.InitializeComponent();

        }

        // Destructor

        ~FrmSettings() {
            this.Dispose();
        }

        /// <summary>
        /// Loading the settings window with a
        /// specific tabpage to focus. Calls default
        /// constructor first.
        /// </summary>
        /// <param name="tabName"></param>

        public FrmSettings(string tabName) : this() {
            tabName = tabName.Insert(0, "t");
            this.tMain.SelectedTab = this.tMain.TabPages[tabName];
            this.txtReadME.Dock = DockStyle.Fill;
            this.grpAboutChild.Dock = DockStyle.Bottom;
        }

        private void FrmSettings_Load(object sender, EventArgs e) {
            addToLoad();
            addHandlers();
        }

        private void addToLoad() {
            Util u = new Util();
            DownloadPicture d = new DownloadPicture();

            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ui\github_attr.txt");
            txtReadME.AppendText(u.getString(u.getOnlineFile("https://raw.githubusercontent.com/Reapism/Skork/master/README.md")));
            picAbout.BackgroundImage = Properties.Resources.skork;
            this.Icon = Properties.Resources.skork_icon;
            this.Text = this.tMain.SelectedTab.Text + " - Settings";
            drawSettings(0);
        }

        /// <summary>
        /// Adds the event handlers for the settings form.
        /// </summary>

        private void addHandlers() {
            this.tMain.Selected += TMain_Selected;
        }

        private void TMain_Selected(object sender, TabControlEventArgs e) =>
            this.Text = this.tMain.SelectedTab.Text + " - Settings";

        private void drawAboutTab() {

            int scaleFactor = this.Height / 2;

            picAbout.Size = new Size(scaleFactor, scaleFactor);
            picAbout.Location = new Point(grpAbout.Width / 2 - picAbout.Width / 2,
                25);

            int xt = grpAboutChild.Width,
                yt = grpAboutChild.Height;

            grpAboutChild.Dock = DockStyle.None;
            grpAboutChild.Width = grpAbout.Width - 10;
            grpAboutChild.Height = this.Height / 4;
            grpAboutChild.Dock = DockStyle.Bottom;

            float sz = (this.Width / 250f) + 10f;

            txtReadME.Font = new Font(txtReadME.Font.OriginalFontName, sz, FontStyle.Regular);
            grpAboutChild.Location = new Point(grpAboutChild.Location.X, this.Size.Height / 2);
        }

        private void drawProjectTab() {
            new ui.SkorkToolStripRender(ref tsProject);
        }

        private void drawPreferencesTab() {

        }

        private void drawGitHubTab() {
            WebBrowser wb = new WebBrowser();

            wb.Navigate("https://github.com/Reapism/Skork/graphs/contributors");
            //wb.Show();
            grpGitHub.Controls.Add(wb);
            wb.Dock = DockStyle.Fill;

        }

        private void drawSettings(byte index) {
            switch (index) {
                case 0:
                    drawAboutTab();
                    return;
                case 1:
                    drawProjectTab();
                    return;
                case 2:
                    drawPreferencesTab();
                    return;
                case 3:
                    drawGitHubTab();
                    return;
                default:
                    return;
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

        private void FrmSettings_SizeChanged(object sender, EventArgs e) {
            drawSettings((byte) tMain.SelectedIndex);
        }

        private void tMain_SelectedIndexChanged(object sender, EventArgs e) {
            drawSettings((byte)tMain.SelectedIndex);
        }
    }
}
