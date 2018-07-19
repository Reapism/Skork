

namespace Skork.exceptions {
    class SkorkInvalidIdentifierException : SkorkException {

        public SkorkInvalidIdentifierException(string exceptionMessage)
            : base(exceptionMessage) {

        }

        public override string ToString() {
            return "SkorkInvalidIdentifierException: " + base.ToString();
        }
    }
}
