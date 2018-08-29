﻿using System.Collections.Specialized;
using Skork.keywords;
using System.Windows.Forms;

namespace Skork.util {

    class SkorkCompile {

        /// <summary>
        /// 
        /// </summary>
        
        private StringCollection code; 

        /// <summary>
        /// Converts string to string collection.
        /// </summary>
        /// <param name="code"></param>

        public SkorkCompile(string code) {
            this.code = new Util().getLines(code);
            cleanCode();
            compile();
        }

        /// <summary>
        /// Takes a parsed string collection and
        /// converts it.
        /// </summary>
        /// <param name="code"></param>

        public SkorkCompile(StringCollection code) {
            this.code = code;
            cleanCode();
            compile();
        }



        public void compile() {
            byte returnType = 0;

            foreach (string item in this.code) {
                returnType = parseCodeLine(item);
            }
        }

        /// <summary>
        /// Returns 0 if valid, 1, 2, 3 etc. invalid.
        /// <para>skork s;</para>
        /// <para>int i = 0;</para>
        /// </summary>
        /// <param name="codeLine">The code line to parse.</param>
        /// <returns></returns>

        private byte parseCodeLine(string codeLine) {
            SkorkKeywords sk = new SkorkKeywords();
            Util u = new Util();

            string line = string.Empty,
                name = string.Empty;
            char[] trails = { '\n', ' ' };

            if (codeLine.Contains(";")) {
                line = u.getLine(codeLine, ';').ToLower();

                foreach (string function in sk.getFunctions()) {
                    if (line.Contains(function)) {
                        //find out which function

                        //tmp.Insert(tmp.IndexOf(function), "\\");
                    }
                }

                foreach (string keyword in sk.getKeywords()) {
                    if (line.ToLower().Contains(keyword)) {
                        line.Insert(line.IndexOf(keyword), "\\");
                    }
                }

                foreach (string type in sk.getTypes()) {
                    if (line.Contains(type.ToLower())) {
                        string tmp = string.Empty;
                        int nextSpace = line.LastIndexOf(' ');                       
                        
                            while (nextSpace != -1) {
                                tmp = line.Substring(0, line.LastIndexOf(' '));
                                nextSpace = nextSpace + line.LastIndexOf(' ');
                                MessageBox.Show(tmp);
                            }

                       
                        line = line.TrimStart(trails);
                        line = line.Insert(0, "\\");
                        line = line.Insert(line.IndexOf(type), "\\");
                       
                    }
                }

                return 0;

            } else {
                return 1;
            }
        }

        /// <summary>
        /// Attempts to remove trailing spaces and new 
        /// lines from code statements and condensing 
        /// code to the bare minimum for compiling.
        /// </summary>

        private void cleanCode() {
            StringCollection newCode = new StringCollection();
            string appendedLine = string.Empty;

            foreach (string line in code) {
                MessageBox.Show(line);
            }

            foreach (string line in code) {
                // somewhere in here need to remove
                // trailing lines and spaces.
                if (line.Contains(";")) {
                    newCode.Add(line);
                    appendedLine = string.Empty;

                } else {
                    appendedLine += line;
                }


            }
            code = newCode;

            foreach (string line in code) {
                MessageBox.Show("after   " + line);
            }
        }



        // A line is valid if it contains a keyword or variable name or comment.
        // int\hi\=\5;

        private string getCodeLine(string line) {
            string codeLine = string.Empty;
            SkorkKeywords sk = new SkorkKeywords();
            if (line.Contains(";")) {



                foreach (string keyword in sk.getKeywords()) {

                    if (line.Contains(keyword)) {

                    }
                }
            }
            return codeLine;
        }


    }
}
