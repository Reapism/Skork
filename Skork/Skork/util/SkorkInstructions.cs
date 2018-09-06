using System.Collections.Generic;
using Skork.keywords;
using System.Windows.Forms;
using System;
using Skork.functions;

namespace Skork.util {

    /// <summary>
    /// Stores the instruction-set for skork to follow.
    /// </summary>

    class SkorkInstructions {
        // <Key, Value> //
        public static Dictionary<string, int> ints;
        private static Dictionary<string, double> doubles;
        private static Dictionary<string, bool> bools;
        private static Dictionary<string, SkorkSprite> sprites;
        private SkorkConventions sc;

        static SkorkInstructions() {
            ints = new Dictionary<string, int>();
            doubles = new Dictionary<string, double>();
            bools = new Dictionary<string, bool>();
            sprites = new Dictionary<string, SkorkSprite>();
        }

        public SkorkInstructions() {
            sc = new SkorkConventions();
        }

        private bool containsKey(string name, Dictionary<string, int> dictionary) {
            return (dictionary.ContainsKey(name));
        }

        private bool containsKey(string name, Dictionary<string, double> dictionary) {
            return (dictionary.ContainsKey(name));
        }

        private bool containsKey(string name, Dictionary<string, bool> dictionary) {
            return (dictionary.ContainsKey(name));
        }

        private bool containsKey(string name, Dictionary<string, SkorkSprite> dictionary) {
            return (dictionary.ContainsKey(name));
        }

        public Type getFunctionType(string func) {
            switch (func) {
                case "sprite":
                    return typeof(SkorkSprite);
                case "loop":
                    return null;
                case "goto":
                    return null;
                case "who":
                    return typeof(SkorkWho);
                default: return null;
            }
        }

        public Type getType(string type) {

            switch (type) {
                case "int":
                    return typeof(int);
                case "double":
                    return typeof(double);
                case "string":
                    return typeof(string);
                case "char":
                    return typeof(char);
                case "byte":
                    return typeof(byte);
                case "short":
                    return typeof(short);
                case "long":
                    return typeof(long);
                default: return null;
            }
        }

        public Type getVariableType(string type) {
            SkorkKeywords sk = new SkorkKeywords();
            int i = 4;
            foreach (string keyword in sk.getKeywords()) {
                if (type.ToLower().Equals(keyword)) {
                    Type t = getType(type.ToLower());
                    return t;
                }
            }
            return null;
        }

        public bool createKey(string type, string name, string value) {
            SkorkKeywords sk = new SkorkKeywords();
            foreach (string keyword in sk.getKeywords()) {
                if (type.ToLower().Equals(keyword)) {
                    Type t = keyword.GetType();
                }
            }
            return false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Key: The name of the identifier.</param>
        /// <param name="value">Value: The value of the identifier.</param>
        /// <returns>If successful.</returns>

        public bool createKey(string name, int value) {

            int ident = sc.isValidIdentifier(name);
            SkorkConsole c = new SkorkConsole();

            switch (ident) {
                case 0:
                    if (containsKey(name, ints)) {
                        return false;
                    } else {
                        ints.Add(new SkorkKeysID().ToString() + "\\" + name, value);
                        return true;
                    }
                case 1:
                    MessageBox.Show(
                        name + " first character \"" + name[0] + "\" is invalid.",
                        "SkorkInvalidIdentifierException");
                    break;
                case 2:
                    MessageBox.Show(
                        name + " contains a character that's invalid!",
                        "SkorkInvalidIdentifierException");
                    break;
                case 3:
                    MessageBox.Show(
                        name + " is too long! Should be <= 25. It's " +
                        name.Length + ".",
                        "SkorkInvalidIdentifierException");
                    break;
                case 4:
                    MessageBox.Show(
                       name + " is a keyword! No variable can be a keyword.",
                       "SkorkInvalidIdentifierException");
                    break;

            }
            return false;

        }

        public bool createKey(string name, double value) {
            if (containsKey(name, doubles)) {
                return false;
            } else {
                doubles.Add(name, value);
                return true;
            }
        }

        public bool createKey(string name, bool value) {
            if (containsKey(name, bools)) {
                return false;
            } else {
                bools.Add(name, value);
                return true;
            }
        }

        public bool createKey(string name, SkorkSprite value) {
            if (containsKey(name, sprites)) {
                return false;
            } else {
                sprites.Add(name, value);
                return true;
            }
        }

        public void temp() {
            foreach (KeyValuePair<string, int> entry in ints) {
                MessageBox.Show($"{entry.Key} = {entry.Value}");
            }


        }

    }
}
