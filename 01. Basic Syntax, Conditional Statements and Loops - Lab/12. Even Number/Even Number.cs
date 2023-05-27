// Create a program that reads a sequence of numbers. If the number is even, print its absolute value in the following
// format: "The number is: {number}" and terminate the program. If the number is odd, print "Please write
// an even number." and continue reading numbers.

using System;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int isAEven = int.Parse(Console.ReadLine());

                if (isAEven % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(isAEven)}");
                    break;
                }
            }
        }
    }
}