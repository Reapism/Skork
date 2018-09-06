using Skork.keywords;

namespace Skork.util {

    /// <summary>
    /// In order to create an object in skork, there are
    /// certain naming conventions that must be met in
    /// order to preserve stability within the program
    /// and not interfere with internal code.
    /// 
    /// <para>Valid identifiers:
    /// An identifier must start with a letter or an underscore.
    /// After the first character, it may contain numbers, 
    /// letters, underscores up to and including 25 characters.</para>
    /// <para>hello, hello1, hello209383783</para>
    /// <para>Invalid Identifiers: Any keyword, unicode, name starting with a numeric.
    /// </para>
    /// <para>1hello, $hello, hello$, he llo, heee...llo</para>
    /// </summary>

    class SkorkConventions {

        public SkorkConventions() {

        }

        /// <summary>
        /// <para>Checks if a string follows skork naming conventions.</para>  
        /// </summary>
        /// <param name="identifier">The identifier to check if its valid</param>
        /// <returns>Returns 0 if the identifier follows the conventions, else an
        /// int refering to how it failed.</returns>

        public int IsValidIdentifier(string identifier) {
            int startInside = 10;
            string invalidChars = "1234567890!@#$%^&*()-+=`~/,.<>;':[]{}\\|?\" ";
            char[] invalidStart = invalidChars.ToCharArray();
            char[] invalidInside = invalidChars.Substring(startInside, 
                invalidChars.Length - startInside).ToCharArray();
            const int charLimit = 25;
            Util u = new Util();

            // Checks if the identifiers first character starts with any character in invalidStart

            if (identifier.Substring(0, 1).IndexOfAny(invalidStart) >= 0) {
                return 1;
            }

            // Checks if the identifier contains invalidInside characters after position 0.

            if (identifier.IndexOfAny(invalidInside) >= 0) {
                return 2;
            }

            // Checks if the identifier is greater or equal to the charLimit

            if (identifier.Length > charLimit) {
                return 3;
            }

            // Checks if the identifier is a keyword.

            SkorkKeywords sk = new SkorkKeywords();
            foreach (string keyword in sk.GetKeywords()) {
                if (identifier.ToLower().Equals(keyword)) {
                    return 4;
                }
            }
            return 0;
        }
    }

}
