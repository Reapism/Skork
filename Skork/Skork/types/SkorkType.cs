using System.Collections.Specialized;

namespace Skork.types {
    class SkorkType {

        protected static StringCollection TYPES;

        static SkorkType() {
            TYPES = new StringCollection();
            new SkorkType().AddTypes();
        }

        public SkorkType() {

        }

        private void AddTypes() {
            TYPES.Add("int");
            TYPES.Add("double");
            TYPES.Add("bool");
            TYPES.Add("string");
            TYPES.Add("char");
            TYPES.Add("byte");
            TYPES.Add("short");
            TYPES.Add("long");
        }

        public bool IsType(string s) => (TYPES.Contains(s));        

        public static StringCollection Types { get { return SkorkType.TYPES; } }
    }
}
