// Create a method, which receives two numbers as parameters:
// • The first number – the base
// • The second number – the power
// The method should return the base raised to the given power.


using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = 0;
            result = RaiseToPower(number, power, result);
            Console.WriteLine(result);
        }

        static double RaiseToPower(double number, double power, double result)
        {
            result += number;
            for (int i = 1; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}