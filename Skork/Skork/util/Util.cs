using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;

namespace Skork.util {
    class Util {

        /// <summary>
        /// Checks if a file path exists; checking if a file exists at a PATH.
        /// </summary>
        /// <param name="path">The path of the file.</param>
        /// <returns>The result of the existing or non-existing file.</returns>

        public bool isValidPath(string path) {
            return (System.IO.File.Exists(path)) ? true : false;
        }

        /// <summary>
        /// Checks to see if the path is a valid directory.
        /// </summary>
        /// <param name="path">The path of the directory.</param>
        /// <returns></returns>

        public bool isValidFolder(string path) {
            return (System.IO.Directory.Exists(path)) ? true : false;
        }

        /// <summary>
        /// Checks if a string is an Int, if it is, return it, else return -1.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>The integer if it is, else, return -1.</returns>

        public int isInt(string s) {
            int i = 0;
            return (int.TryParse(s, out i)) ? i : -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>

        public double isDouble(string s) {
            double d = 0;
            return (double.TryParse(s, out d)) ? d : -1.0;
        }

        /// <summary>
        /// Generic method to swap two types.
        /// <para>Ex: 10, 5 = 5, 10.</para>
        /// </summary>
        /// <typeparam name="T">The generic type.</typeparam>
        /// <param name="left">The left parameter.</param>
        /// <param name="right">The right parameter.</param>

        public void swap<T>(ref T left, ref T right) {
            T tmp = left;
            left = right;
            right = tmp;
        }

        /// <summary> 
        /// Returns a substring from another string from char c1, to c2.
        /// </summary>
        /// <param name="s">The string to read from.</param>
        /// <param name="c1">Inclusive begining character.</param>
        /// <param name="c2">Exclusive ending character.</param>
        /// <returns>The substring from c1(incl.) - c2(excl.), else; "null"</returns>

        public string readUntil(string s, char c1, char c2 = '\n') {
            return (s.Contains(c1) && s.Contains(c2)) ? s.Substring(s.IndexOf(c1), s.IndexOf(c2) - s.IndexOf(c1)) : "skork-null";
        }

        public string readUntil(string s, string s1, char c2 = '\n') {
            return (s.Contains(s1) && s.Contains(c2)) ? s.Substring(s.IndexOf(s1), s.IndexOf(c2) - s.IndexOf(s1)) : "skork-null";
        }

        public string readUntil(string s, char c1, string s2 = "\n") {
            return (s.Contains(c1) && s.Contains(s2)) ? s.Substring(s.IndexOf(c1), s.IndexOf(s2) - s.IndexOf(c1)) : "skork-null";
        }

        public string readUntil(string s, string s1, string s2 = "\n") {
            return (s.Contains(s1) && s.Contains(s2)) ? s.Substring(s.IndexOf(s1), s.IndexOf(s2) - s.IndexOf(s1)) : "skork-null";
        }

        public string readBetween(string s, char c1, char c2) {
            return (s.Contains(c1) && s.Contains(c2)) ? s.Substring(s.IndexOf(c1) + 1, s.IndexOf(c2) - s.IndexOf(c1) - 1) : "skork-null";
        }

        public string getLine(string s) {
            return s.Substring(0, s.LastIndexOf('\n'));
        }

        public StringCollection getLines(string s) {
            StringCollection sc = new StringCollection();
            StringReader sr = new StringReader(s);
            string line;

            while (((line = sr.ReadLine()) != null)) {
                if (line != string.Empty)
                    sc.Add(line);
            }
            return sc;
        }


        /// <summary>
        /// Return the contents of the entire file as a string.
        /// </summary>
        /// <param name="path">The path of the file to read from.</param>
        /// <returns>All the contents of the file as type string.</returns>

        public string readFile(string path) {
            string s;
            try {
                s = System.IO.File.ReadAllText(path);
            } catch (Exception e) {
                throw e;
            }

            return s;
        }

        /// <summary>
        /// Gets a file online in a byte array.
        /// </summary>
        /// <param name="url">The url to download from.</param>
        /// <returns></returns>

        public byte[] getFile(string url) {
            byte[] b;

            using (WebClient client = new WebClient()) {

                try {
                    b = client.DownloadData(url);
                } catch {
                    return null;
                }

                return b;
            }
        }

        /// <summary>
        /// Returns a string from converting a byte array.
        /// </summary>
        /// <param name="arr">The byte array to convert</param>
        /// <returns>Returns a string from converting a byte array.</returns>

        public string getString(byte[] arr) {
            return System.Text.Encoding.ASCII.GetString(arr);
        }

        /// <summary>
        /// Returns a string stating the instances hashcode.
        /// </summary>
        /// <returns>A string containing the hashcode of the instnace.</returns>
        public override string ToString() => $"The Util class object {this.GetHashCode()}";
    }
}
