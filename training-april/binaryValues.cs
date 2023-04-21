using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.VisualBasic;

namespace training_april
{
    class binaryValues
    {
        
        public static Dictionary<int,string> PrintBinary (int n)
        {
            if (n<0)
            {
                return null;
            }
            Dictionary<int, string> binaryDic = new Dictionary<int, string>();
            for (int i = 1; i <= n; i++)
            {
                string bynary_equivalent = Convert.ToString(i, 2);
                binaryDic.Add(i, bynary_equivalent);
            }
            return binaryDic;
        }

        public static void PrintBinaryUsingQueue(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Nothing to print");
                return;
            }
            Queue<int> mybinary= new Queue<int>();
            mybinary.Enqueue(1);

            for (int i = 1; i <= n; i++)
            {
                int current = mybinary.Dequeue();
                Console.WriteLine($"{i.ToString()} {current}");
                mybinary.Enqueue(current * 10);
                mybinary.Enqueue(current * 10 + 1);
               
            }
            Console.WriteLine();
        }

        public static Boolean IsMatching( string str)
        {
                      
            Stack<char> stackParent = new Stack<char>();
            Dictionary<char,char> symbols = new Dictionary<char,char>();
            symbols.Add(')', '(');
            symbols.Add('>', '<');
            symbols.Add(']', '[');
            for (int i = 0; i < str.Length; i++)
            {
                char current = str[i];
                if (symbols.ContainsValue(current))
                {
                    stackParent.Push(current);
                    continue;
                }
                if (symbols.ContainsKey(current) &&(stackParent.Count==0 || 
                    symbols.GetValueOrDefault(current)!= stackParent.Pop()))
                {
                    return false;
                }
            }
            return stackParent.Count == 0;
        }


    }


    }

