
using System.Collections.Generic;


namespace Skork.keywords {
    abstract class SkorkKeywords {
        
        protected Dictionary<string, object> keyword;

        public SkorkKeywords() {
            keyword.Add("Sprite", new SkorkSprite());
            keyword.Add("Skork", new SkorkFalse());
            keyword.Add("True", new SkorkFalse());
            keyword.Add("False", new SkorkFalse());
            keyword.Add("False", new SkorkFalse());

        }

        public string isKeyword(string s) {
            return (keyword.ContainsKey(s)) ? s : null;      
        }


    }
}
