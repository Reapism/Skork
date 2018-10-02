namespace Skork.functions {

    /// <summary>
    /// Who(object) Function: 
    /// <para>Calls the ToString() method on a specific object.</para>
    /// Used for debugging your Skork code.
    /// Usage new SkorkWho(object).ToString();
    /// </summary>

    class SkorkWho : SkorkFunction{

        private string who;

        public SkorkWho(object o) {
            who = o.ToString();
        }

        public override string ToString() {
            return who;
        }
    }
}
