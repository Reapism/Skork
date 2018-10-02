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
            //CleanCode();
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
            SkorkKeyword sk = new SkorkKeyword();
            Util u = new Util();

            string line = string.Empty,
                name = string.Empty;
            char[] trails = { '\n', ' ' };

            return 0;     
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
            SkorkKeyword sk = new SkorkKeyword();
            const char bs = '\\';

            if (line.Contains(";")) {



                foreach (string keyword in sk.Keywords) {

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
