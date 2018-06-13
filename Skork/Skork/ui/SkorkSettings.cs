using Skork.util;

namespace Skork.ui {
    class SkorkSettings {


        public SkorkSettings() {

        }

        public void parseText(string path, string attr) {
            Util u = new Util();
            if (u.isValidPath(path)) {
                string txt = System.IO.File.ReadAllText(path);

                int start = txt.LastIndexOf(attr);


            }
        }

    }
}
