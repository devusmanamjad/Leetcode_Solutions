/*
 Author: Muhammad Usman Amjad
 Problem Link: https://leetcode.com/problems/two-sum/
 Date: 25/03/2023
 */


using System.Collections.Generic;

namespace Leetcode.Easy
{
    static class TwoSum
    {
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
    }
}
