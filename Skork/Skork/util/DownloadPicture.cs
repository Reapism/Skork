using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Skork.util {
    class DownloadPicture {

        /// <summary>
        /// Downloads an image from an unknown fileformat into a png.
        /// </summary>
        /// <param name="url">The url of the picture to download.</param>
        /// <returns></returns>

        public Image downloadImage(string url) {
            WebClient web = new WebClient();
            byte[] data;
            MemoryStream ms;
            Image img;
            try {
                data = web.DownloadData(new Uri(url));
                ms = new MemoryStream(data);
                img = Image.FromStream(ms); 
                img.Save(ms, ImageFormat.Png);
                ms.Close();
                return img;
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
                return null;
            }

            
        }
        
        public Image downloadImage(string url, PictureBox p) {
            return null;
        }

    }
}
