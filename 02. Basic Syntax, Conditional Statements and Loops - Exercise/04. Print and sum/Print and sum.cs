// You will receive two whole numbers from the console representing the start and the end of a sequence of numbers.
// Your task is to print two lines:
// • On the first line, print all numbers from the start of the sequence to the end inclusive.
// • On the second line, print the sum of the sequence in the format: "Sum: {sum}"

using System;

namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startLine = int.Parse(Console.ReadLine()!);
            int endLine = int.Parse(Console.ReadLine()!);
            int sum = 0;

            for (int i = startLine; i <= endLine; i++)
            {
                if (endLine> i)
                {
                    Console.Write($"{i} ");
                    sum += i;
                }
                else
                {
                    Console.Write($"{i}");
                    sum += i;
                }
               
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}