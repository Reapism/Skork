namespace Skork.util {

    /// <summary>
    /// <para>Adds a unique number to separate every
    /// variable/object created in skork.</para> Not
    /// a singleton because newer objects increment
    /// the id, and statics because when creating
    /// new objects of this class, we don't want to
    /// create more 'id's'.
    /// </summary>

    class SkorkKeysID {

        // The unique id.
        private static long id;

        /// <summary>
        /// Static constructor which initializes
        /// id to 0 during compile time.
        /// </summary>

        static SkorkKeysID() {
            id = 0;
        }

        /// <summary>
        /// Default constructor which increments
        /// id by 1.
        /// </summary>
        
        public SkorkKeysID() {
            id += 1;
        }

        /// <summary>
        /// Returns the current id.
        /// </summary>
        /// <returns></returns>

        public override string ToString() => id.ToString();

    }
}
