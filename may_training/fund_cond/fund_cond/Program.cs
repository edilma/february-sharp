using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fund_cond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int unique = RemoveDuplicates2(nums);

           Console.WriteLine(unique);

        }

        public static int RemoveDuplicates(int[] nums)
        {
            List<int> uniques = nums.Distinct().ToList();
            return uniques.Count;

        }

        public static int RemoveDuplicates2(int[] nums)
        {
            List<int> uniques = nums.Distinct().ToList();
          //check if the element in nums is in uniques
          // delete the repeats from nums
            for (int i = 0; i < nums.Length; i++)
            {
               // Console.WriteLine(nums[i]);
                if (!uniques.Contains(nums[i]))
                {
                    nums[i] = 0;
                }
            }
            return uniques.Count;
            


        }


    }
}
