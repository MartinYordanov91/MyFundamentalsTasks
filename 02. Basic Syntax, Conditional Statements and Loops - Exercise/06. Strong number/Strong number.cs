// Write a program that receives a single integer and calculates if it's strong or not. A number is strong, if the sum of
// the factorials of each digit is equal to the number itself.
// Example: 145 is a strong number, because 1! + 4! + 5! = 145.
// Print "yes", if the number is strong and "no", if the number is not strong.

using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int copyOfNum = num;
            int factorials = 0;
            int result = 0;

            while (copyOfNum > 0)
            {
                factorials = copyOfNum % 10;
                copyOfNum /= 10;

                int n = 1;

                for (int i = factorials; i > 0; i--)
                {
                    n *= i;
                }
                result += n;
            }
            if (result == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}