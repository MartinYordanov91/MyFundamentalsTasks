// You will receive a number N in the range [0…1000]. Calculate the Factorial of N and print out the result.
// Use the class BigInteger from the built-in .NET library System.Numerics.dll

using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}