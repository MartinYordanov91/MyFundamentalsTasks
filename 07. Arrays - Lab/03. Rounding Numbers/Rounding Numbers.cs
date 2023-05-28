// Read an array of real numbers (space separated), round them in "away from 0" style and print the output as in
// the examples:

using System;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arry = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < arry.Length; i++)
            {
                    Console.WriteLine($"{arry[i]} => {(int)Math.Round(arry[i], MidpointRounding.AwayFromZero)}");
            }

        }
    }
}