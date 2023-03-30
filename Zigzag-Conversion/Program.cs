using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            string text = "In a village's of La Mancha, e";
            var words = text.Split( );
            List<string> theWords = new List<string>();

            foreach (var word in words)
            {
                bool isWord = true;
                foreach (char letter in word)
                {
                    if (!Char.IsLetter(letter))
                    {
                        isWord = false;
                    }
                   
                }
                if (isWord)
                {
                    theWords.Add(word);
                }

            }

            foreach (var word in theWords)
            {
                Console.WriteLine(word);
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
            // Your code here
            return null;
        }
    }
    //MOst frequently used words in a text
    


}

