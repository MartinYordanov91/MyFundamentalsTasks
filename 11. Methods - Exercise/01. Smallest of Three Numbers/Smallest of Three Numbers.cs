// Create a method that prints out the smallest of three integer numbers.

using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumber(a, b, c));
        }
        static int SmallestNumber(int a, int b, int c)
        {
            int smallest = 0;
            if (a <= b && a <= c)
            {
                smallest = a;
            }
            else if (b <= c && b <= a)
            {
                smallest = b;
            }
            else if (c <= a && c <= b)
            {
                smallest = c;
            }
            return smallest;
        }
    }
}