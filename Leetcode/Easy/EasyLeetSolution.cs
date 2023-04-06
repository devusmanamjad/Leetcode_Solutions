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
            Console.WriteLine("     3. Binary Search.");
            Console.WriteLine("     4. Search Insert Position.");
            Console.WriteLine("     5. Squares of a Sorted Array.");
            Console.WriteLine("     6. Rotate Array.");




        }
        #endregion
        #region 1. Two Sum
        public static void twoSum(int[] nums, int target)
        {
            List<int> result = new List<int>();

            for (int i = 0; i <= nums.Length-1; i++)
            {
                for (int j = i + 1; j <= nums.Length-1; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result.Add(i);
                        result.Add(j);
                    };
                }
            }
            Console.WriteLine("");
            Console.Write("Result to get the target value: "+ target + ",is by adding the values of indexes: [" + string.Join(", ", result) + "]");
            Console.WriteLine("");
            Console.WriteLine("");

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

        #region 3. Binary Search
        public static int BinarySearch(int[] nums, int target) {
            int start = 0;
            int end = nums.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (target == nums[mid])
                {
                    return mid;
                }
                else if (target < nums[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }

        #endregion

        #region 4. Search Insert Position
        public static int SearchInsertPosition(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (target == nums[mid])
                {
                    return mid;
                }
                else if (target < nums[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return start;
        }

        #endregion

        #region 5. Squares of a Sorted Array
        public  static int[] SquaresOfSortedArray(int[] nums)
        {
            Array.Sort(nums);
            int[] resultArray = new int[nums.Length];
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                resultArray[i] = nums[i] * nums[i];
            }
            //  if (resultArray.Length > 0 ){
            Array.Sort(resultArray);
            //  }
            return resultArray;
        }

        #endregion


        #region 6. Rotate Array.
        public static void RotateArray(int[] nums, int k)
        {

            int len = nums.Length;
            int _k = k;
            if (_k > len)
                _k = _k % len;
            int[] rotated = new int[len];
            Array.Copy(nums, len - _k, rotated, 0, _k);
            Array.Copy(nums, 0, rotated, _k, len - _k);
            Array.Copy(rotated, nums, len);
            Console.WriteLine("[" + string.Join(", ", rotated) + "]");
            //List<int> skimed = new List<int>();
            //List<int> Result = new List<int>();

            //int[] resultArray = new int[nums.Length];
            //for (int i = nums.Length-1; i >= nums.Length - (k); i--) {
            //    skimed.Add(nums[i]);
            //}


            //for (int i = skimed.Count()-1; i >= 0; i--)
            //{
            //    Result.Add(skimed[i]);

            //}
            //for (int i = 0; i <= nums.Length - (k+1); i++)
            //{
            //    Result.Add(nums[i]);

            //}

            //Console.WriteLine("[" + string.Join(", ", Result) + "]");

            //return skimed.ToArray();
        }

        #endregion


    }
}
