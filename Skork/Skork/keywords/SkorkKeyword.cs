using System.Collections.Specialized;

namespace Skork.keywords {

    /// <summary>
    /// Stores a static reference to all the types, functions,
    /// and generic keywords in Skork. Also contains member
    /// functions for checking if a specific type, function, or
    /// keyword is contained.
    /// </summary>

    class SkorkKeyword {
        
        public static readonly StringCollection KEYS;

        static SkorkKeyword() {
            KEYS = new StringCollection();
            new SkorkKeyword().AddKeywords();
        }      

        private void AddKeywords() {
            KEYS.Add("return");
            KEYS.Add("if");
            KEYS.Add("else");
        }

        public bool IsKeyword(string s) => (KEYS.Contains(s));

        public StringCollection Keywords { get { return KEYS; } }

    }
}
