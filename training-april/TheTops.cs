using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace training_april
{
    internal class TheTops
    {
        
        public static string onlyWords(string s)
        {
            string word ="";
            int apostrophCount = 0;
            int apostrophCode=39;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]) || apostrophCode== (int)s[i])
                {
                    word = word + s[i];
                }
            }
            apostrophCount = word.Count(x=>x == apostrophCode);
            if (apostrophCount>2 || (word.Length==1 && (int)word[0]==39))
            {
                return null;
            }
            return word;


        }
        public static List<string> ValidWords(string s)
        {
            List<string> realWords = new List<string>();
            string[] wordsArray = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
 
            foreach (string item in wordsArray)
            {
                string word = onlyWords(item);
                if (!String.IsNullOrEmpty(word))
                {
                realWords.Add(word);
                }
            }
            return realWords;
        }

        public static List<string> MaxCount(string s)
        {
           
            List<string> validWords = ValidWords(s);

            List<string> mainwords = validWords.GroupBy(word => word.ToLowerInvariant())
                .OrderByDescending(x => x.Count()).Select(x => x.Key).Take(3).ToList();

            return mainwords;

        }


    }
}
