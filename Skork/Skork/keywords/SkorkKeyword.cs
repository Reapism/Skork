using System.Collections.Generic;


namespace Skork.keywords {
    abstract class SkorkKeyword {

        protected Dictionary<string, string> keyword;

        public SkorkKeyword() {
            keyword.Add("keyword", "value"); // value points to the actual keyword
        }



    }
}
