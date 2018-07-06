
using System.Collections.Generic;


namespace Skork.keywords {
    class SkorkKeywords {

        protected Dictionary<string, object> keyword;

        public SkorkKeywords() {
            keyword = new Dictionary<string, object>();  
        }

        public void addKeyword(string key, object o) {
            keyword.Add(key, o);
        }

        private void populateKeywords(ref Dictionary<string, object> d) {
            d.Add("sprite", new SkorkSprite());
            d.Add("loop", new object());
        }

        public bool isKeyword(string s) {
            return (this.keyword.ContainsKey(s)) ? true : false;
        }

        public void invokeKeyword(string s) {
            string key = "";
            object o = new object();
            if (isKeyword(s) && keyword.TryGetValue(key, out o)) {
                invokeMe(o);
            }
        }

        public void invokeMe(object o) {
            System.Windows.Forms.MessageBox.Show(o.ToString());
        }
    }
}
