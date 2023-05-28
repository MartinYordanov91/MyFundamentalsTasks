// A top number is an integer that holds the following properties:
// • Its sum of digits is divisible by 8, e.g. 8, 17, 88
// • Holds at least one odd digit, e.g. 232, 707, 87578
// • Some examples of top numbers are: 17, 161, 251, 4310, 123200
// Create a program to print all top numbers in the range [1…n].
// You will receive a single integer from the console, representing the end value

using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            bool isDivisibleEight = false;
            bool isHaveOdd = false;

            for (int i = 1; i <= inputNum; i++)
            {
                isDivisibleEight = IsDivisible(isDivisibleEight, i);
                isHaveOdd = HaveOdd(isHaveOdd, i);
                Print(isDivisibleEight, isHaveOdd, i);

                isDivisibleEight = false; 
                isHaveOdd = false;
            }
        }

        static void Print(bool isDivisibleEight, bool isHaveOdd, int i)
        {
            if (isDivisibleEight && isHaveOdd)
            {
                Console.WriteLine(i);
            }
        }

        private static bool IsDivisible(bool isDivisibleEight, int i)
        {
            if (IntToIntArray(i).Sum() % 8 == 0)
            {
                isDivisibleEight = true;
            }

            return isDivisibleEight;
        }

        static bool HaveOdd(bool isHaveOdd, int i)
        {
            int dublicate = i;
            while (dublicate > 0)
            {
                if (dublicate % 2 == 1)
                {
                    isHaveOdd = true;
                    break;
                }
                else
                {
                    dublicate /= 10;
                }
            }

            return isHaveOdd;
        }

        static int[] IntToIntArray(int num)
        {
            if (num == 0)
                return new int[1] { 0 };

            List<int> digits = new List<int>();

            for (; num != 0; num /= 10)
                digits.Add(num % 10);

            int[] array = digits.ToArray();
            System.Array.Reverse(array);

            return array;
        }
    }
}