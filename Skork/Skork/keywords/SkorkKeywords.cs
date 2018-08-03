
using System.Collections.Specialized;


namespace Skork.keywords {
    class SkorkKeywords {


        // Keywords belongs to the class, not an instance.
        protected static StringCollection keywords;

        public SkorkKeywords() {
            keywords = new StringCollection();
            keywords.Add("sprite");
            keywords.Add("loop");
            keywords.Add("goto");
            keywords.Add("who");
            keywords.Add("loop");
        }

        public bool isKeyword(string s) {
            return (keywords.Contains(s)) ? true : false;
        }

        public StringCollection getKeywords() {
            return SkorkKeywords.keywords;
        }
    }
}
