namespace Skork.keywords {



    abstract class SkorkLeft : SkorkSprite {

        private SkorkSprite s;

        public SkorkLeft(SkorkSprite s) {
            this.s = s;
            left(s, 19);
        }

        public int left(SkorkSprite s, int x) {
            if (x - 1 < 0) {
                return x;
            } else {
                return x - 1;
            }
        }

        public int left(int x, int n) {
            if (x - 1 >= 0 && n > 0) return left(s, x - 1);
            return 1;
        }


    }
}
