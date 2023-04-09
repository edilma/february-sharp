using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace training_april
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = " PvJZQkgd pvMxP ZhHEeCrDV Yplb:ZhHEeCrDV:kFBSMXyyd'?pvMxP-ZhHEeCrDV ZhHEeCrDV?kFBSMXyyd'_kFBSMXyyd' cgFv pvMxP_Yplb:PvJZQkgd.ZhHEeCrDV ZhHEeCrDV.PvJZQkgd-cgFv!kFBSMXyyd'!PvJZQkgd/ZhHEeCrDV zbyUuh Yplb PvJZQkgd!kFBSMXyyd' cgFv ZhHEeCrDV,Yplb.ZhHEeCrDV PvJZQkgd cgFv!cgFv cgFv PvJZQkgd pvMxP.kFBSMXyyd'.kFBSMXyyd' ZhHEeCrDV Yplb ZhHEeCrDV PvJZQkgd ZhHEeCrDV zbyUuh kFBSMXyyd';kFBSMXyyd'-cgFv?pvMxP/ZhHEeCrDV kFBSMXyyd' pvMxP ZhHEeCrDV?zbyUuh ZhHEeCrDV_Yplb ZhHEeCrDV?Yplb-zbyUuh zbyUuh zbyUuh zbyUuh_Yplb.ZhHEeCrDV.pvMxP zbyUuh zbyUuh?Yplb ZhHEeCrDV zbyUuh ZhHEeCrDV:zbyUuh,ZhHEeCrDV kFBSMXyyd' zbyUuh kFBSMXyyd'-ZhHEeCrDV-ZhHEeCrDV,cgFv!ZhHEeCrDV kFBSMXyyd' tvo Yplb.zbyUuh cgFv?PvJZQkgd:kFBSMXyyd' Yplb cgFv-ZhHEeCrDV zbyUuh kFBSMXyyd' pvMxP pvMxP;cgFv Yplb kFBSMXyyd'!Yplb!ZhHEeCrDV;pvMxP zbyUuh kFBSMXyyd',kFBSMXyyd'-pvMxP_PvJZQkgd_PvJZQkgd zbyUuh.pvMxP zbyUuh;PvJZQkgd kFBSMXyyd':ZhHEeCrDV/ZhHEeCrDV/cgFv;tvo,kFBSMXyyd' PvJZQkgd:PvJZQkgd,zbyUuh";
            //TheTops.MaxCount(words);

            //string wordstwo = "e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e";
            List<string> answer = TheTops.MaxCount(words);
            List<string> answer2 = Top3(words);

            foreach (string item in answer)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("--------- // -------");
            foreach (string item in answer2)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine(answer.Count());

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
         
          

    }
}
