using Skork.exceptions;

namespace Skork.util {

    /// <summary>
    /// In order to create an object in skork, there are
    /// certain naming conventions that must be met in
    /// order to preserve stability within the program
    /// and not interfere with internal code.
    /// 
    /// <para>Valid identifiers, instance variables, etc.</para>
    /// An identifier must start with a letter or an underscore.
    /// After the first character, it may contain numbers, 
    /// letters, connectors, etc.
    /// <para>Invalid Identifiers: Any keyword, unicode, name starting with a numeral,
    /// </para>
    /// </summary>

    class SkorkConventions {



        public SkorkConventions() {

        }

        /// <summary>
        /// <para>Checks if a string follows skork naming conventions.</para>  
        /// </summary>
        /// <exception cref="Skork.exceptions.SkorkException">Thrown when
        /// an identifier is not valid.</exception>
        /// <exception cref="Skork.exceptions.SkorkInvalidIdentifierException">Thrown when
        /// an identifier is not valid.</exception>
        /// <param name="identifier">The identifier to check if its valid</param>
        /// <returns>Returns if the identifier follows the conventions!</returns>

        public int isValidIdentifier(string identifier) {
            string invalidChars = "1234567890!@#$%^&*()-+=`~/,.<>;':[]{}\\|?\" ";
            char[] invalidStart = invalidChars.ToCharArray();
            char[] invalidInside = invalidChars.Substring(9, invalidChars.Length - 9).ToCharArray();
            const int charLimit = 25;
            Util u = new Util();

            if (identifier.Substring(0, 1).IndexOfAny(invalidStart) >= 0) {
                return 1;
            }

            if (identifier.IndexOfAny(invalidInside) >= 0) {
                return 2;
            }

            if (identifier.Length >= charLimit) {
                return 3;
            }
            //System.Windows.Forms.MessageBox.Show(invalidInside.ToString());
            //string inv = string.Empty;
            //foreach (char c in identifier) {
            //    inv += c;
            //}
            //foreach (char c in invalidChars) {

            //}
            //if (inv.Contains(c.ToString())) {
               return 0;
            //}
        }
           
            //throw new SkorkInvalidIdentifierException(identifier +
            //" is not a valid identifier! See *** for naming conventions in Skork!");
            //throw new SkorkInvalidIdentifierException(identifier +
            //$" is too long! Valid Identifiers are {charLimit} length or shorter!" +
            // " See *** for naming conventions in Skork!");
        }

}
