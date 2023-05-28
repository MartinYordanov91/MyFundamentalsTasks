// Create a program that calculates the difference between the sum of the even and the sum of the odd numbers in
// an array.

using System;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArry = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int even = 0;
            int odd = 0;
            int result = 0;

            for (int i = 0; i < intArry.Length; i++)
            {
                if (intArry[i] % 2 ==0 )
                {
                    even += intArry[i];
                }
                else
                {
                    odd += intArry[i];
                }
            }
            Console.WriteLine(even - odd);
        }
    }
}