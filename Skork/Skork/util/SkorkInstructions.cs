﻿using System.Collections.Generic;
using Skork.keywords;
using System;
using System.Windows.Forms;

namespace Skork.util {

    /// <summary>
    /// Represents the instruction set for skork to follow.
    /// </summary>

    class SkorkInstructions {
                    // <Key, Value> //
        private static Dictionary<string, int> ints;
        private static Dictionary<string, double> doubles;
        private static Dictionary<string, bool> bools;
        private static Dictionary<string, SkorkSprite> sprites;


        public SkorkInstructions() {
            ints = new Dictionary<string, int>();
            doubles = new Dictionary<string, double>();
            bools = new Dictionary<string, bool>();
            sprites = new Dictionary<string, SkorkSprite>();
        }

        public bool containsKey(string name, Dictionary<string, int> dictionary) {
            if (dictionary.ContainsKey(name)) {
                return true;
            }
            return false;
        }

        public bool containsKey(string name, Dictionary<string, double> dictionary) {
            if (dictionary.ContainsKey(name)) {
                return true;
            }
            return false;
        }

        public bool containsKey(string name, Dictionary<string, bool> dictionary) {
            if (dictionary.ContainsKey(name)) {
                return true;
            }
            return false;
        }

        public bool containsKey(string name, Dictionary<string, SkorkSprite> dictionary) {
            if (dictionary.ContainsKey(name)) {
                return true;
            }
            return false;
        }

        public bool createInt(string name, int value) {
            if (!containsKey(name, ints)) {
                ints.Add(name.GetHashCode().ToString(), value);
                return true;        
            }
            return false;
        }

        public void getList() {
            MessageBox.Show("getList");
            foreach(string name in ints.Keys) {
                MessageBox.Show(name);
            }
        }

        public bool hashInt() {
            return false;
        }


    }
}