using System.Collections.Specialized;

namespace Skork.util {
    class SkorkConsole {

        private StringCollection c;

        public SkorkConsole() {
            this.c = new StringCollection();
            this.c.Add("Skork Console:");
        }

        public SkorkConsole(string append) {
            this.c.Add(append);
        }

        public StringCollection getConsole() {
            return this.c;
        }


        public override string ToString() => this.c[0];
        
    }
}
