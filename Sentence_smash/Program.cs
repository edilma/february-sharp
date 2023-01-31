using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_smash
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "hello", "amazing", "world" };
            Console.WriteLine(Smash(words));
            Console.ReadLine();

        }
        public static string Smash(string[] words)
        {
            return String.Join(" ", words);
        }
    }
}
   


