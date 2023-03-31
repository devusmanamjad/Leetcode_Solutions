using Leetcode.Easy;

namespace DataLoader
{
    public class Program
    {
        public static void Main(string[] pcsid)
        {
            int[] NumberArr = new int[] { 1, 5, 8, 100 };
            EasyLeetSolution.printEasyLeetList();
            Console.Write("Please Select the Problem Number:    ");
            string prblm =  Console.ReadLine();

            switch (prblm) {
                case "1":
                    EasyLeetSolution.twoSum(NumberArr, 108);
                    break;

                case "2":
                    EasyLeetSolution.isPalindrome( 108);
                    break;

            }

        }
    }
}