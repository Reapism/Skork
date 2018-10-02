using System.Collections.Specialized;

namespace Skork.functions {
    class SkorkFunction {

        protected static StringCollection FUNCS;


        static SkorkFunction() {
            FUNCS = new StringCollection();
            new SkorkFunction().AddFunctions();
        }

        public SkorkFunction() {

        }

        private void AddFunctions() {
            FUNCS.Add("sprite");
            FUNCS.Add("loop");
            FUNCS.Add("goto");
            FUNCS.Add("who");
        }

        public bool IsFunction(string s) => (FUNCS.Contains(s));


        public static StringCollection Functions { get { return SkorkFunction.FUNCS; } }

    }
}
