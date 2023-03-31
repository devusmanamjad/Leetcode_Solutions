using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public static class EasyLeetSolution
    {

        #region Print the Easy List 
        public static void printEasyLeetList()
        {
            Console.WriteLine("");
            Console.WriteLine(" Please select the problem from the following you want to solve:");
            Console.WriteLine("     1. Two Sum.");
            Console.WriteLine("     2. Palindrome Number.");
            Console.WriteLine("     3. Longest Common Prefix.");

        }
        #endregion
        #region 1. Two Sum
        public static void twoSum(int[] nums, int target)
        {
            List<int> result = new List<int>();

            for (int i = 0; i <= nums.Length; i++)
            {
                for (int j = i + 1; j <= nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result.Add(i);
                        result.Add(j);
                    };
                }
            }
            Console.WriteLine("[" + string.Join(", ", result) + "]");
        }
        #endregion
        #region 2. Palindrome Number.
        public static bool isPalindrome(int value)
        {
            int Mod, sum = 0, temp;
            temp = value;
            while (value > 0)
            {
                Mod = value % 10;
                sum = (sum * 10) + Mod;
                value = value / 10;
            }
            return (temp == sum) ? true : false;

        }
        #endregion


    }
}
