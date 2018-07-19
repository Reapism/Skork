using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
