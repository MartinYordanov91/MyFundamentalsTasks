// Write a program that determines if a person is baby, child, teenager, adult or elder based on the given age.
// The boundaries are:
// • 0-2 – baby
// • 3-13 – child
// • 14-19 – teenager
// • 20-65 – adult
// • >= 66 – elder
// All the values are inclusive.

using System;

namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine()!);

            switch (age)
            {
                case >= 0 and <= 2: Console.WriteLine("baby"); break;
                case >= 3 and <= 13: Console.WriteLine("child"); break;
                case >= 14 and <= 19: Console.WriteLine("teenager");break;
                case >= 20 and <= 65: Console.WriteLine("adult"); break;
                case >= 66: Console.WriteLine("elder"); break;
                
            }
        }
    }
}