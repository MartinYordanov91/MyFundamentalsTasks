// Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we
// cannot directly compare two floating-point numbers a and b by a == b, because of the nature of the floating-point
// arithmetic. Therefore, we assume two numbers are equal if they are more close to each other than some fixed
// constant eps.
// You will receive two lines, each containing a floating-point number. Your task is to compare the values of the two
// numbers.

using System;

namespace _03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal numA = decimal.Parse(Console.ReadLine());
            decimal numB = decimal.Parse(Console.ReadLine());

            if (numA > numB)
            {
                numA -= numB;
                if (0.000001m > numA)
                    Console.WriteLine("True");
                
                else
                    Console.WriteLine("False");
                
            }
            else
            {
                numB -= numA;
                if (0.000001m > numB)
                    Console.WriteLine("True");

                else
                    Console.WriteLine("False");
            }
        }
    }
}