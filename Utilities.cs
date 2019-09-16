using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities {

    public static string ProcessText(string textIn) {

        /*~~~~~ Check if Number/String ~~~~~ */
        return word 'string' if user enters string
        //return word 'number' if user enters a number
        return textIn;
         
        if (char.IsNumber(textIn) == true) {
            return "number";
        }

       if (char.IsNumber(textIn) == false) {
            return "string";
        }

        /*~~~~~ Letter Count Solution ~~~~~ */
        public static string avTextLength(string str) {
            string[] words = str.Split();
        int total = 0;
        foreach (var word in words) { total += word.Length; }
        return "" + total / words.Length;    

        }

    }
}
