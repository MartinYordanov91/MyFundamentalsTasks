// Write a program that, depending on the first line of the input, reads an int, a double or a string.
// • If the data type is int, multiply the number by 2.
// • If the data type is real, multiply the number by 1.5 and format it to the second decimal point.
// • If the data type is a string, surround the input with '$'.
// Print the result on the console.

using System;

namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            if (comand == "int")
            {
                MultiplayInt();
            }
            else if (comand == "real")
            {
                MultiplyDecimal();
            }
            else if (comand == "string")
            {
                StringEmplementate();
            }

        }
        static void StringEmplementate()
        {
            string str = Console.ReadLine();
            Console.WriteLine("${0}$", str);
        }

        static void MultiplyDecimal()
        {
            decimal digit = decimal.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", digit * 1.5m);
        }

        static void MultiplayInt()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number * 2);
        }
    }
}