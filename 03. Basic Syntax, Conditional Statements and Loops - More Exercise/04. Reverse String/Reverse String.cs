// Create a program which reverses a string and prints it on the console

using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] textRevers = input.ToCharArray();
            Array.Reverse(textRevers);
            Console.WriteLine(textRevers);
            
        }
    }
}