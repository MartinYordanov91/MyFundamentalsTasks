// Create a program that receives three lines of input:
// • On the first line – a string – "add", "multiply", "subtract", "divide".
// • On the second line – a number.
// • On the third line – another number.
// You should create four methods (for each calculation) and invoke the corresponding method depending on the
// command. The method should also print the result (needs to be void).

using System;
using System.ComponentModel;

namespace _03._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (comand)
            {
                case "add":
                    Add(a, b);
                    break;
                case "multiply":
                    Multiply(a, b);
                    break;
                case "subtract":
                    Subtract(a, b);
                    break;
                case "divide":
                    Divide(a, b);
                    break;

            }
        }
        private static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        private static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        private static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        private static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}