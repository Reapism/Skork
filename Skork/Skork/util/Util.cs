using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skork.util {
    class Util {

        /// <summary>
        /// Checks if a file path exists.
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
        /// Generic method to swap two types.
        /// <para>Ex: 10, 5 = 5, 10.</para>
        /// </summary>
        /// <typeparam name="T">The generic type.</typeparam>
        /// <param name="left">The left parameter</param>
        /// <param name="right">The right parameter</param>

        public void swap<T>(ref T left, ref T right) {
            T tmp;
            tmp = left;
            left = right;
            right = tmp;
        }

        /// <summary> 
        /// Returns a substring from another string from char c1, to c2.
        /// <para>c1 inclusive, c2 exclusive.</para>>
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c1">Beginning character to start</param>
        /// <param name="c2"></param>
        /// <returns></returns>

        public string readUntil(string s, char c1, char c2 = '\n') {
            return (s.Contains(c1) && s.Contains(c2)) ? s.Substring(s.IndexOf(c1), s.IndexOf(c2) - s.IndexOf(c1)) : "null";                   
        }

        public string readUntil(string s, string s1, char c2 = '\n') {
            return (s.Contains(s1) && s.Contains(c2)) ? s.Substring(s.IndexOf(s1), s.IndexOf(c2) - s.IndexOf(s1)) : "null";
        }

        public string readUntil(string s, string s1, string s2 = "\n") {
            return (s.Contains(s1) && s.Contains(s2)) ? s.Substring(s.IndexOf(s1), s.IndexOf(s2) - s.IndexOf(s1)) : "null";
        }
    }
}
