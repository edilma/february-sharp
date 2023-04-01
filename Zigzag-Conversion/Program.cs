using System;
using System.Collections.Generic;
using System.Linq;

using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zigzag_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 };
            //Find the int that is an odd number of times.  Many possible
            var uniques = myArray.Distinct();
            Dictionary<int, int> myItems = new Dictionary<int, int>();
            
            foreach (var item in uniques)
            {
                int timesItem = myArray.Count(x => x == item);
                myItems.Add(item, timesItem);
            }
            List<int> results = new List<int>();

            foreach (var item in myItems)
            {
                if (item.Value%2!=0)
                {
                    results.Add(item.Key);
                }
                
            }

            int answer = find_it( myArray);
            //Console.WriteLine ($"The answer is {answer}");

            string s = "a a a  b  c c  d d d d  e e e e e";
         
          


            List<string> orderedWords = Top3(s);

            foreach (var item in orderedWords)
            {
                Console.WriteLine(item);
            }



            Console.ReadLine();
        }
        //Find the int that is an odd number of times.  There is only one
        public static int find_it(int[] seq)
        {
            var uniques = seq.Distinct();
            int answer = -1;
            
            foreach (var item in uniques)
            {
                int timesItem = seq.Count(x => x == item);
                if (timesItem%2!=0)
                {
                    answer= item;
                }  
            }
            return answer;
            }


        public static List<string> Top3(string s)
        {
            List<string> answer = new List<string>();
            if (String.IsNullOrWhiteSpace(s))
            {
                return answer;
            }
            else
            {
                string[] words = s.ToLower().Split();
                List<string> allWords = new List<string>();
                foreach (string word in words)
                {
                    string cleanWord = Regex.Replace(word, @"[^a-zA-Z']+", "");
                    if (!String.IsNullOrEmpty(cleanWord))
                    {
                        allWords.Add(cleanWord);
                    }
                    
                }
                List<string> orderedWords = allWords.GroupBy(x => x)
                    .OrderByDescending(x => x.Count())
                    .Select(x => x.Key)
                    .ToList();

                //PrintLista(orderedWords);

                if (orderedWords.Count < 4)
                {
                    return orderedWords;
                }
                else
                {
                    return orderedWords.Take(3).ToList();
                }
            }
            
    
        }

        public static void PrintLista(List<string> aLista)
        {
            foreach (var item in aLista)
            {
                Console.WriteLine(item);
            }
        }
    }
    //MOst frequently used words in a text
    


}

