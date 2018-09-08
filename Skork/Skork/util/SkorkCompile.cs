using Skork.keywords;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace Skork.util {

    class SkorkCompile {

        /// <summary>
        /// 
        /// </summary>

        private StringCollection code;

        /// <summary>
        /// Takes a parsed string collection and
        /// converts it.
        /// </summary>
        /// <param name="code"></param>

        public SkorkCompile(StringCollection code) {
            this.code = code;
            CleanCode();
            SplitCode(ref this.code);
            TestSplit();
        }



        public void Compile() {
            byte returnType = 0;

            foreach (string item in this.code) {
                returnType = ParseCodeLine(item);
            }
        }

        /// <summary>
        /// Returns 0 if valid, 1, 2, 3 etc. invalid.
        /// <para>skork s;</para>
        /// <para>int i = 0;</para>
        /// </summary>
        /// <param name="codeLine">The code line to parse.</param>
        /// <returns></returns>

        private byte ParseCodeLine(string codeLine) {
            SkorkKeywords sk = new SkorkKeywords();
            Util u = new Util();

            string line = string.Empty,
                name = string.Empty;
            char[] trails = { '\n', ' ' };

            if (codeLine.Contains(";")) {
                line = u.GetLine(codeLine, ';').ToLower();

                foreach (string function in sk.GetFunctions()) {
                    if (line.Contains(function)) {
                        //find out which function

                        //tmp.Insert(tmp.IndexOf(function), "\\");
                    }
                }

                foreach (string keyword in sk.GetKeywords()) {
                    if (line.ToLower().Contains(keyword)) {
                        line.Insert(line.IndexOf(keyword), "\\");
                    }
                }

                foreach (string type in sk.GetTypes()) {
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

        private void CleanCode() {
            StringCollection newCode = new StringCollection();


            foreach (string line in this.code) {
                int pos = line.IndexOf(' ');

                if (pos != -1) { // Checks if there is a space.
                    string subStr = line.Substring(pos, line.IndexOf(' ', pos));
                    MessageBox.Show(subStr);
                    newCode.Add(subStr);
                }



            }

            this.code = newCode;

        }

        /// <summary>
        /// Attempts to convert multi-line code statements
        /// into one line in Skork readable format.
        /// SkorkReAdAbLeFoRmat
        /// </summary>

        private void SplitCode(ref StringCollection code) {
            StringCollection newCode = new StringCollection();
            string multiLine = string.Empty; //represents a line concatonated from different lines.

            foreach (string line in code) {
                multiLine += line;

                if (multiLine.Contains(";")) {
                    newCode.Add(multiLine);
                    multiLine = string.Empty;
                }

                code = newCode;
            }

        }
        // A line is valid if it contains a keyword or variable name or comment.
        // int\hi\=\5;

        private string GetCodeLine(string line) {
            string codeLine = string.Empty;
            SkorkKeywords sk = new SkorkKeywords();
            const char bs = '\\';

            if (line.Contains(";")) {



                foreach (string keyword in sk.GetKeywords()) {

                    if (line.Contains(keyword)) {
                        line = line.Trim();
                    }
                }
            }
            return codeLine;
        }



        public void TestSplit() {

            foreach (string line in this.code) {
                MessageBox.Show(line);
            }


        }
    }
}
