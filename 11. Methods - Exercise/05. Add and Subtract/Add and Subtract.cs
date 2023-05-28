// You will receive 3 integers. Create a method that returns the sum of the first two integers and another method that
// subtracts the third integer from the result of the sum method.

using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int result = 0;

            result = Sum(a, b);
            result = Subtracts(c, result);

            Console.WriteLine(result);
        }

        static int Subtracts(int c, int result)
        {
            result -= c;
            return result;
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}