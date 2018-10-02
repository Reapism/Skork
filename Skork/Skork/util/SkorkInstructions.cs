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
        public static Dictionary<string, int> Ints;
        private static Dictionary<string, double> Doubles;
        private static Dictionary<string, bool> Bools;
        private static Dictionary<string, SkorkSprite> Sprites;
        private SkorkConventions sc;

        static SkorkInstructions() {
            Ints = new Dictionary<string, int>();
            Doubles = new Dictionary<string, double>();
            Bools = new Dictionary<string, bool>();
            Sprites = new Dictionary<string, SkorkSprite>();
        }

        public SkorkInstructions() {
            sc = new SkorkConventions();
        }

        private bool ContainsKey(string name, Dictionary<string, int> dictionary) {
            return (dictionary.ContainsKey(name));
        }

        private bool ContainsKey(string name, Dictionary<string, double> dictionary) {
            return (dictionary.ContainsKey(name));
        }

        private bool ContainsKey(string name, Dictionary<string, bool> dictionary) {
            return (dictionary.ContainsKey(name));
        }

        private bool ContainsKey(string name, Dictionary<string, SkorkSprite> dictionary) {
            return (dictionary.ContainsKey(name));
        }

        public Type GetFunctionType(string func) {
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

        private void TestGetType() {

            Type test = GetType("int");

            if (test.IsValueType && test == typeof(int)) {
                MessageBox.Show("Yes it is.");
                return;
            }

        }

        public Type GetType(string type) {

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

        public Type GetVariableType(string type) {
            SkorkKeyword sk = new SkorkKeyword();
            int i = 4;

            foreach (string keyword in sk.Keywords) {
                if (type.ToLower().Equals(keyword)) {
                    Type t = GetType(type.ToLower());
                    return t;
                }
            }
            return null;
        }

        public bool CreateKey(string type, string name, string value) {
            SkorkKeyword sk = new SkorkKeyword();

            foreach (string keyword in sk.Keywords) {
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

        public bool CreateKey(string name, int value) {

            int ident = sc.IsValidIdentifier(name);
            SkorkConsole c = new SkorkConsole();

            switch (ident) {
                case 0:
                    if (ContainsKey(name, Ints)) {
                        return false;
                    } else {
                        Ints.Add(new SkorkKeysID().ToString() + "\\" + name, value);
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

        public bool CreateKey(string name, double value) {
            if (ContainsKey(name, Doubles)) {
                return false;
            } else {
                Doubles.Add(name, value);
                return true;
            }
        }

        public bool CreateKey(string name, bool value) {
            if (ContainsKey(name, Bools)) {
                return false;
            } else {
                Bools.Add(name, value);
                return true;
            }
        }

        public bool CreateKey(string name, SkorkSprite value) {
            if (ContainsKey(name, Sprites)) {
                return false;
            } else {
                Sprites.Add(name, value);
                return true;
            }
        }

        public void Temp() {
            foreach (KeyValuePair<string, int> entry in Ints) {
                MessageBox.Show($"{entry.Key} = {entry.Value}");
            }


        }

    }
}
