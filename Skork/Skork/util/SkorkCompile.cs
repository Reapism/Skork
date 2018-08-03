using System.Collections.Specialized;

namespace Skork.util {
    class SkorkCompile {

        private StringCollection code;
        

        public SkorkCompile(string code) {
            Util u = new Util();
            this.code = u.getLines(code);
        }

        public SkorkCompile(StringCollection code) {
            this.code = code;
        }





    }
}
