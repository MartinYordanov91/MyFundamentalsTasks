// Read two arrays and determine whether they are identical or not. The arrays are identical, if all their elements are
// equal. If the arrays are identical, find the sum of the elements of one of them and print the following message to
// the console: "Arrays are identical. Sum: {sum}"
// Otherwise, find the first index where the arrays differ and print the following message to the console: "Arrays
// are not identical. Found difference at {index} index"

using System;
using System.Reflection;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArry = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondArry = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            bool identical = true;

            for (int i = 0; i < firstArry.Length; i++)
            {
                if (firstArry[i] == secondArry[i])
                {
                    sum += firstArry[i];
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    identical = false;
                    break;
                }
            }
            if (identical) { Console.WriteLine($"Arrays are identical. Sum: {sum}"); }
        }
    }
}