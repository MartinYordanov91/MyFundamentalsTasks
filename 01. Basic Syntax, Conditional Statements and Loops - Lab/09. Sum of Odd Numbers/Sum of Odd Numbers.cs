// Create a program that prints on a new line the next n odd numbers (starting from 1). On the last row print the sum
// of all n odd numbers.
// Input
// A single number n is read from the console, indicating how many odd numbers need to be printed.
// Output
// Print the next n odd numbers, starting from 1, separated by new lines. On the last line, print the sum of these
// numbers.
// Constraints
// • n will be in the interval [1…100]

using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numN = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 1; i <= numN; i++)
            {
                result += i * 2 - 1;

                Console.WriteLine(i*2-1);
            }
            Console.WriteLine($"Sum: {result}");
        }
    }
}
