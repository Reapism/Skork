

namespace Skork.keywords {
    class SkorkFalse : SkorkSprite {

        private bool val;

        public SkorkFalse() {
            val = false;
        }

        protected bool getVal() {
            return val;
        }

        protected void setVal(bool b) {
            val = b;
        }

    }
}
