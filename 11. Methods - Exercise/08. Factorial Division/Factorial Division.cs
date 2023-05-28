// Read two integers. Calculate the factorial of each number. Divide the first result by the second and print the result
// of the division formatted to the second decimal point.

using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", Factorials(first) / Factorials(second));

        }
        static decimal Factorials(decimal first)
        {
            if (first < 1)
            {
                return 1;
            }
            return first *= Factorials(first - 1);
        }
    }
}