using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class UserInput
    {
        public int[] ReadArrayFromInput()
        {

            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int[] array = new int[size];
            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        public int CastStringToInt(string inputString)
        {
            int userInt;
            while (!int.TryParse(inputString, out userInt))
            {
                Console.WriteLine("Invalid input. Please enter an integer as string:");
                inputString = Console.ReadLine();
            }
            return userInt;
        }
    }
}
