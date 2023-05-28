// Create a method that receives a single integer n and prints an NxN matrix using this number as a filler

using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Matrix(n);
        }

        static void Matrix(int n)
        {
            for (int m = 0; m < n; m++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}