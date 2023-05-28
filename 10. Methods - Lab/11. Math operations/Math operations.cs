// Write a method that receives two numbers and an operator, calculates the result and returns it. You will be given
// three lines of input. The first will be the first number, the second one will be the operator and the last one will be
// the second number.
// The possible operators are: /, *, + and -.

using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            string a = Console.ReadLine();
            int numberB = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculator(numberA,a,numberB));

        }

        static double Calculator(int numberA, string a, int numberB)
        {
            double result = 0;
            if (a == "/")
            {
                result = numberA / numberB;
            }
            else if (a == "*")
            {
                result = numberA * numberB;
            }
            else if (a == "+")
            {
                result= numberA + numberB;
            }
            else if(a == "-")
            {
                result = numberA - numberB;
            }

            return result;
        }
    }
}