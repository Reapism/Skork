using System.Collections.Specialized;

namespace Skork.keywords {

    /// <summary>
    /// Stores a static reference to all the types, functions,
    /// and generic keywords in Skork. Also contains member
    /// functions for checking if a specific type, function, or
    /// keyword is contained.
    /// </summary>

    class SkorkKeywords {

        protected static StringCollection types;
        protected static StringCollection funcs;
        protected static StringCollection keywords;

        static SkorkKeywords() {
            funcs = new StringCollection();
            keywords = new StringCollection();
            types = new StringCollection();

            funcs.Add("sprite");
            funcs.Add("loop");
            funcs.Add("goto");
            funcs.Add("who");

            keywords.Add("return");
            keywords.Add("if");
            keywords.Add("else");

            types.Add("int");
            types.Add("double");
            types.Add("bool");
            types.Add("string");
            types.Add("char");
            types.Add("byte");
            types.Add("short");
            types.Add("long");
        }

        public bool IsFunction(string s) {
            return (funcs.Contains(s)) ? true : false;
        }

        public bool IsKeyword(string s) {
            return (keywords.Contains(s)) ? true : false;
        }

        public bool IsType(string s) {
            return (types.Contains(s)) ? true : false;
        }

        public StringCollection GetFunctions() => SkorkKeywords.funcs;

        public StringCollection GetKeywords() => SkorkKeywords.keywords;

        public StringCollection GetTypes() => SkorkKeywords.types;

    }
}
