
namespace Skork.functions {
    class OperationPlus {

        public int operationPlus(int left, int right) {
            return left + right;
        }

        public int operationPlus(int left, double right) {
            return left + int.Parse(right.ToString());
        }

        public int operationPlus(double left, int right) {
            return int.Parse(left.ToString()) + right;
        }

        public int operationPlus(double left, double right) {
            return int.Parse(left.ToString()) + int.Parse(right.ToString());
        }
    }
}
