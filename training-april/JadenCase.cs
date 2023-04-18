using System;
using System.Collections.Generic;
using System.Text;

namespace training_april
{
    class JadenCase
    {

        public static string ToJadenCase(string phrase)
        {
            string[] words = phrase.Split(" ");
            string[] result = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {

                string capitalizedWord = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);
                result[i] =capitalizedWord;
            }
            string newWord = string.Join(" ", result);
            return newWord;
        }
        // Another way using linq
        //return String.Join(" ", phrase.Split().Select(i => Char.ToUpper(i[0]) + i.Substring(1)));

    }
}
