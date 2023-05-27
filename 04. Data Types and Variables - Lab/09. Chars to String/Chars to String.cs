// Create a program that reads 3 lines of input. On each line, you get a single character. Combine all the characters into
// one string and print it on the console.

using System;

namespace _09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            for (int i = 0; i < 3; i++)
            {
                char simbol = char.Parse(Console.ReadLine());
                output += simbol;
            }
            Console.WriteLine(output);
        }
    }
}