using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skork.util {
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
