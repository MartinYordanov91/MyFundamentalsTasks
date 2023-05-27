// Create a program that receives an integer n and print all triples of the first n small Latin letters, ordered
// alphabetically:

using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int end = 97 + n;

            for (int i = 97; i < end; i++)
            {
                for (int m = 97; m < end; m++)
                {
                    for (int r = 97; r < end; r++)
                    {
                        Console.WriteLine("{0}{1}{2}", (char)i, (char)m, (char)r);

                    }
                }
            }

        }
    }
}