// 8. Triangle of Numbers
// Write a program, which receives a number – n and prints a triangle from 1 to n.
// Constraints
// • n will be in the interval [1...20].

using System;

namespace _08._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int n = 1; n <= i; n++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}