

namespace Skork.exceptions {

    /// <summary>
    /// Represents a SkorkException that should be thrown
    /// when the user attempts to create an identifier/variable
    /// that is not valid.
    /// </summary>

    class SkorkInvalidIdentifierException : SkorkException {

        public SkorkInvalidIdentifierException(string exceptionMessage)
            : base(exceptionMessage) {

        }

        public override string ToString() {
            return "SkorkInvalidIdentifierException: " + base.ToString();
        }
    }
}
