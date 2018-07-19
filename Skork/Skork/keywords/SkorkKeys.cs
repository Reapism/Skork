using System;

namespace Skork.util {

    class SkorkKeys {

        private static long id;

        static SkorkKeys() {
            id = 0;
        }

        public SkorkKeys() {
            id += 1;
        }

        public override string ToString() => id.ToString();
        
    }
}
