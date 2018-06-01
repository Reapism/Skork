using System;
using System.Collections.Generic;
using System.Drawing;


namespace Skork.functions {
    abstract class SkorkLeft {

        public SkorkLeft() {
            left(19);
        }

        public int left(int x) {
            if (x - 1 < 0) {
                return x;
            } else {
                return x - 1;
            }
        }

        public int left(int x, int n) {
            if (x - 1 >= 0 && n > 0) return left(x - 1);
            return 1;
        }


    }
}
