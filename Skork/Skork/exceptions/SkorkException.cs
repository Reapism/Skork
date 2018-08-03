using System;

namespace Skork.exceptions {

    /// <summary>
    /// Represents a simple, vague SkorkException.
    /// </summary>

    class SkorkException : Exception {

        private string exceptionMessage;

        public SkorkException(string exceptionMessage) {
            this.exceptionMessage = exceptionMessage;
        }

        public override string ToString() {
            return this.exceptionMessage;
        }

    }
}
