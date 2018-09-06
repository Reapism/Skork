using System.Collections.Specialized;

namespace Skork.util {
    class SkorkConsole {

        private StringCollection c;

        public SkorkConsole() {
            this.c = new StringCollection {
                "Skork Console:"
            };
        }

        public SkorkConsole(string append) {
            this.c.Add(append);
        }

        public StringCollection GetConsole() {
            return this.c;
        }


        public override string ToString() => this.c[0];

    }
}
