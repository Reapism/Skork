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

        public bool IsValidPath(string path) {
            return (System.IO.File.Exists(path)) ? true : false;
        }

        /// <summary>
        /// Checks to see if the path is a valid directory.
        /// </summary>
        /// <param name="path">The path of the directory.</param>
        /// <returns></returns>

        public bool IsValidFolder(string path) {
            return (System.IO.Directory.Exists(path)) ? true : false;
        }

        /// <summary>
        /// Checks if a string is an Int, if it is, return it, else return -1.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>The integer if it is, else, return -1.</returns>

        public int IsInt(string s) {
            return (int.TryParse(s, out int i)) ? i : -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>

        public double IsDouble(string s) {
            return (double.TryParse(s, out double d)) ? d : -1.0;
        }

        /// <summary>
        /// Generic method to swap two types.
        /// <para>Ex: 10, 5 = 5, 10.</para>
        /// </summary>
        /// <typeparam name="T">The generic type.</typeparam>
        /// <param name="left">The left parameter.</param>
        /// <param name="right">The right parameter.</param>

        public void Swap<T>(ref T left, ref T right) {
            T tmp = left;
            left = right;
            right = tmp;
        }

        /// <summary> 
        /// Returns a substring from another string from char c1[in], to c2[ex].
        /// </summary>
        /// <param name="s">The string to read from.</param>
        /// <param name="c1">Inclusive begining character.</param>
        /// <param name="c2">Exclusive ending character.</param>
        /// <returns>The substring from c1(incl.) - c2(excl.), else; "null"</returns>

        public string ReadUntil(string s, char c1, char c2 = '\n') {
            return (s.Contains(c1) && s.Contains(c2)) ? s.Substring(s.IndexOf(c1),
                s.IndexOf(c2) - s.IndexOf(c1)) : "skork-null";
        }

        /// <summary> 
        /// Returns a substring from another string from string s1[in], to c2[ex].
        /// </summary>
        /// <param name="s">The string to read from.</param>
        /// <param name="c1">Inclusive begining string.</param>
        /// <param name="c2">Exclusive ending character.</param>
        /// <returns>The substring from c1(incl.) - c2(excl.), else; "null"</returns>

        public string ReadUntil(string s, string s1, char c2 = '\n') {
            return (s.Contains(s1) && s.Contains(c2)) ? s.Substring(s.IndexOf(s1),
                s.IndexOf(c2) - s.IndexOf(s1)) : "skork-null";
        }

        /// <summary> 
        /// Returns a substring from another string from string c1[in], to s2[ex].
        /// </summary>
        /// <param name="s">The string to read from.</param>
        /// <param name="c1">Inclusive begining character.</param>
        /// <param name="c2">Exclusive ending string.</param>
        /// <returns>The substring from c1(incl.) - c2(excl.), else; "null"</returns>

        public string ReadUntil(string s, char c1, string s2 = "\n") {
            return (s.Contains(c1) && s.Contains(s2)) ? s.Substring(s.IndexOf(c1),
                s.IndexOf(s2) - s.IndexOf(c1)) : "skork-null";
        }

        /// <summary> 
        /// Returns a substring from another string from string s1[in], to s2[ex].
        /// </summary>
        /// <param name="s">The string to read from.</param>
        /// <param name="c1">Inclusive begining string.</param>
        /// <param name="c2">Exclusive ending string.</param>
        /// <returns>The substring from s1(incl.) - s2(excl.), else; "null"</returns>

        public string ReadUntil(string s, string s1, string s2 = "\n") {
            return (s.Contains(s1) && s.Contains(s2)) ? s.Substring(s.IndexOf(s1),
                s.IndexOf(s2) - s.IndexOf(s1)) : "skork-null";
        }

        /// <summary>
        /// Reads between 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>

        public string ReadBetween(string s, char c1, char c2) {
            return (s.Contains(c1) && s.Contains(c2)) ? s.Substring(s.IndexOf(c1) + 1,
                s.IndexOf(c2) - s.IndexOf(c1) - 1) : "skork-null";
        }

        /// <summary>
        /// Gets a line from a string from beginning to a carriage-return (\n)
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>Returns a substring from s where a new line is contained.</returns>

        public string GetLine(string s) {
            int i = s.LastIndexOf('\n');
            return (i != -1) ? s.Substring(0, i): s + "\n";
        }

        /// <summary>
        /// Gets a line from a string from beginning to a specific character.
        /// If character is not found, returns a string
        /// </summary>
        /// <param name="s">The string.</param>
        /// <param name="c">The character to terminate the substring.</param>
        /// <returns>Returns a substring from s where c is contained.</returns>

        public string GetLine(string s, char c) {
            int i = s.LastIndexOf(c);
            return (i != -1) ? s.Substring(0, i) : s + "\n";
        }

        /// <summary>
        /// Determines if the string contains only a specific character.
        /// </summary>
        /// <param name="s">The string to search.</param>
        /// <param name="c">The character to compare.</param>
        /// <returns>Returns true if the string contains only the character, false otherwise.</returns>

        public bool ContainsOnly(string s, char c) {
            for (int i = 0; i < s.Length; i++) {
                if (s.ElementAt<char>(i) != c)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Determines if a character appears in a string. 
        /// </summary>
        /// <param name="s">The string to search.</param>
        /// <param name="c">The character to compare.</param>
        /// <returns></returns>

        public bool DoesNotContain(string s, char c) {
            for (int i = 0; i < s.Length; i++) {
                if (s.ElementAt<char>(i) == c) { return false;}       
            }
            return true;
        }

        /// <summary>
        /// Separates a string into a collection.
        /// </summary>
        /// <param name="s">The string to get lines from.</param>
        /// <returns>A string collection of substrings.</returns>

        public StringCollection GetLines(string s) {
            StringCollection sc = new StringCollection();
            StringReader sr = new StringReader(s);
            string line;

            while (((line = sr.ReadLine()) != null)) {
                if (line != string.Empty && !(ContainsOnly(line, ' ')))
                    sc.Add(line);
            }
            sr.Close();
            return sc;
        }

        /// <summary>
        /// Return the contents of the entire file as a string.
        /// </summary>
        /// <param name="path">The path of the file to read from.</param>
        /// <returns>All the contents of the file as type string.</returns>

        public string ReadFile(string path) {
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

        public byte[] GetOnlineFile(string url) {
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
        /// <param name="arr">The byte array to convert.</param>
        /// <returns>Returns a string from a byte array.</returns>

        public string GetString(byte[] arr) => System.Text.Encoding.ASCII.GetString(arr);

        /// <summary>
        /// Returns a byte array from converting a string.
        /// </summary>
        /// <param name="s">The string to convert.</param>
        /// <returns>Returns a byte array from a string.</returns>

        public byte[] GetBytes(string s) => System.Text.Encoding.ASCII.GetBytes(s);

        /// <summary>
        /// Returns a string stating the instances hashcode.
        /// </summary>
        /// <returns>A string containing the hashcode of the instance.</returns>

        public override string ToString() => $"The Util class object {GetHashCode()}";
    }
}
