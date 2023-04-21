using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace training_april
{
    class Program
    {
        static void Main(string[] args)
        {
            //string words = " PvJZQkgd pvMxP ZhHEeCrDV Yplb:ZhHEeCrDV:kFBSMXyyd'?pvMxP-ZhHEeCrDV ZhHEeCrDV?kFBSMXyyd'_kFBSMXyyd' cgFv pvMxP_Yplb:PvJZQkgd.ZhHEeCrDV ZhHEeCrDV.PvJZQkgd-cgFv!kFBSMXyyd'!PvJZQkgd/ZhHEeCrDV zbyUuh Yplb PvJZQkgd!kFBSMXyyd' cgFv ZhHEeCrDV,Yplb.ZhHEeCrDV PvJZQkgd cgFv!cgFv cgFv PvJZQkgd pvMxP.kFBSMXyyd'.kFBSMXyyd' ZhHEeCrDV Yplb ZhHEeCrDV PvJZQkgd ZhHEeCrDV zbyUuh kFBSMXyyd';kFBSMXyyd'-cgFv?pvMxP/ZhHEeCrDV kFBSMXyyd' pvMxP ZhHEeCrDV?zbyUuh ZhHEeCrDV_Yplb ZhHEeCrDV?Yplb-zbyUuh zbyUuh zbyUuh zbyUuh_Yplb.ZhHEeCrDV.pvMxP zbyUuh zbyUuh?Yplb ZhHEeCrDV zbyUuh ZhHEeCrDV:zbyUuh,ZhHEeCrDV kFBSMXyyd' zbyUuh kFBSMXyyd'-ZhHEeCrDV-ZhHEeCrDV,cgFv!ZhHEeCrDV kFBSMXyyd' tvo Yplb.zbyUuh cgFv?PvJZQkgd:kFBSMXyyd' Yplb cgFv-ZhHEeCrDV zbyUuh kFBSMXyyd' pvMxP pvMxP;cgFv Yplb kFBSMXyyd'!Yplb!ZhHEeCrDV;pvMxP zbyUuh kFBSMXyyd',kFBSMXyyd'-pvMxP_PvJZQkgd_PvJZQkgd zbyUuh.pvMxP zbyUuh;PvJZQkgd kFBSMXyyd':ZhHEeCrDV/ZhHEeCrDV/cgFv;tvo,kFBSMXyyd' PvJZQkgd:PvJZQkgd,zbyUuh";
            //TheTops.MaxCount(words);

            //string wordstwo = "e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e";
            //List<string> answer = TheTops.MaxCount(words);
            //List<string> answer2 = Top3(words);

            //foreach (string item in answer)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine("--------- // -------");
            //foreach (string item in answer2)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine(answer.Count());
            //string phrase = "How can mirrors be real if our eyes aren't real";
            //string newWord = JadenCase.ToJadenCase(phrase);
            //string answer = Casing.ToJadenCase(words);

            // StringBuilder stringbuilder = new StringBuilder();
            // stringbuilder.Append("hello ");
            // stringbuilder.Append("world, ");
            // stringbuilder.Insert(0, "This is me saying");
            // stringbuilder.Remove(2, 4);
            //String alpha = stringbuilder.ToString();

            //string word = "Viva la madam que viene";
            //string word2 = "Sally is a great worker";
            //string word3 = "";
            ////Console.WriteLine(IsPalindrome(word));
            //Console.WriteLine(ReverseWords(word));
            //Console.WriteLine(ReverseWords(word2));
            //Console.WriteLine(ReverseWords(word3));

            //int[] nums;
            //double[] otherNums = new double[5];

            //string[] availablePets = { "dog", "cat",  "fish" };
            //string[] unavailablePets = {"bird", "snake", "lizard" , "rabbit"};

            int[] numbers = { 7, 2, 8, 4, 0 ,-3};
            Console.WriteLine(MaximumProduct(numbers));
            

            //Array.ForEach(availablePets,Console.WriteLine);
            //Console.WriteLine();
            //Array.ForEach(unavailablePets,Console.WriteLine);

            //Console.WriteLine(alpha);

            Console.ReadLine();
            
           

            
        }
        //This is the solution with Regex
        //My solution is in TheTops class
        public static List<string> Top3(string s)
        {
            return Regex.Matches(s.ToLowerInvariant(), @"('*[a-z]'*)+")
         .GroupBy(match => match.Value)
         .OrderByDescending(g => g.Count())
         .Select(p => p.Key)
         .Take(3)
         .ToList();

        }

        public static Boolean IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }

            }
            return true;
        }

        public static string ReverseWords(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return str;
            }
            string normalize = str.ToLowerInvariant();
            string[] words = normalize.Split(' ');
            StringBuilder finalWord = new StringBuilder();
            
            foreach (string word in words)
            {
                string reverse = Reverse(word);
                finalWord.Append(reverse);
                finalWord.Append(' ');

            }
            return finalWord.ToString().Trim();
            
        }

        public static string Reverse(string str)
        {
            char[] chartoArray = str.ToCharArray();
            Array.Reverse(chartoArray);
            return new string(chartoArray);
        }

        public static int MaximumProduct(int[] nums)
        {
            int max = int.MinValue;
            int length = nums.Length;
            if (length<2)
            {
                return max;
            }
            for (int i = 0; i < length-1; i++)
            {
                for (int j = i+1; j < length; j++)
                {
                    int product = nums[i] * nums[j];
                    if (product>max)
                    {
                        max = product;
                    }
                }
            }
            return max;
        }

        // find the maximum product of two numbers in an unsorted array
        
       



    }
}
