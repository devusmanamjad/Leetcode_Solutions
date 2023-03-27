using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal static class IsPalindrome
    {
        public static bool isPalindrome(int value)
        {
            int  Mod, sum = 0, temp;
            temp = value;
            while (value > 0)
            {
                Mod = value % 10;
                sum = (sum * 10) + Mod;
                value = value / 10;
            }
            return (temp == sum)?  true: false;

        }
    }
}
