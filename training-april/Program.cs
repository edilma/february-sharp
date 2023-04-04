using System;
using System.Collections.Generic;
using System.Linq;

namespace training_april
{
    class Program
    {
        static void Main(string[] args)
        {

            string words = "  , e   .. ";
            string wordstwo = "  , e   .. ";
            
            List<string> answer = TopThree(wordstwo);
            //string[] thewords = wordstwo.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in answer)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine(answer.Count());

            Console.ReadLine();
            
           

            
        }
        public static List<string> Top3(string s)
        {
            List<string> answer = new List<string>();
            List<char> listofChars = new List<char>();
            if (s.Length==0)
            {
                return answer;
            }
            else
            {
                listofChars.AddRange(s);

                for (int i = 0; i < s.Length; i++)
                {
                    if (!Char.IsLetter(listofChars[i]) && listofChars[i] != '\'')
                    {
                        listofChars[i] = ' ';
                    }
                }
                string onlyLetters = new String(listofChars.ToArray());
                Console.WriteLine($"the string is: {onlyLetters} ");
                string[] thewords = onlyLetters.Split(" ");
                for (int i = 0; i < thewords.Length; i++)
                {
                    if (String.IsNullOrEmpty(thewords[i]))
                    {
                        Console.WriteLine("hola");
                    }
                }


                
                List<string> finalWords = thewords.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Key).ToList();
               
                if (finalWords.Count < 3)
                {
                    return finalWords;
                }
                else
                {
                    return finalWords.Take(3).ToList();
                }

            }
         
            

        }
        public static List<string> TopThree(string s)
        {
            List<string> topThreeWords = new List<string>();
            if (String.IsNullOrEmpty(s))
            {
                return topThreeWords;
            }
            else
            {
                string[] thewords = s.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();

                List<string> arrayWords = new List<string>();

                foreach (var item in thewords)
                {
                    string myWord = clearWord(item);
                    if (!wordFrequencies.ContainsKey(myWord))
                    {
                        wordFrequencies.Add(myWord, 1);
                    }
                    else
                    {
                        wordFrequencies[myWord] = wordFrequencies[myWord] + 1;
                    }
                }
                //foreach (var item in wordFrequencies)
                //{
                //    Console.WriteLine($"the word {item.Key} appears {item.Value} times");
                //}



                List<string> listOrderedWords = wordFrequencies.Keys.OrderByDescending(x => wordFrequencies[x]).ToList();
                
                


                if (listOrderedWords.Count<3)
                {
                    return listOrderedWords;
                }
                else
                {
                    return listOrderedWords.Take(3).ToList(); 
                }
                
            }


        }
        public static string clearWord(string s)
        {
            string word = "";
            int i = 0;
            while (i < s.Length)
            {
                if (Char.IsLetter(s[i]) || (s[i] == '\''))
                {
                    word = word + s[i];
                    i++;
                }
                else
                {
                    i++;
                }

            }
            return word;
        }


        public static List<string> clearWord2(string s)
        {
            List<string> words = new List<string>();
            string word = "";
            int i = 0;
            while (i<s.Length)
            {
                if (Char.IsLetter(s[i]) || (s[i] == '\''))
                {
                    word = word + s[i];
                    i++;
                }
                else
                {
                    if (Char.IsWhiteSpace(s[i]))
                    {
                        words.Add(word);
                        word = "";
                    }
                    i++;
                }

            }
            return words;

}

    }
}
