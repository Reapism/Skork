using System;

namespace Skork.exceptions {
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
