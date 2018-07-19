using System.Collections.Specialized;

namespace Skork.util {

    class SkorkCode {

        public SkorkCode() {

        }

        public StringCollection cleanCode(ref StringCollection code) {
            Util u = new Util();
            StringCollection sc = new StringCollection();
            StringCollection sc2 = new StringCollection();
            foreach (string item in sc) {
                sc.Add(trimString(item, ' '));
            }
            return sc; 
        }

        public string trimString(string s, char c = ' ') {
            return s.Trim(c);
        }

    }
}
