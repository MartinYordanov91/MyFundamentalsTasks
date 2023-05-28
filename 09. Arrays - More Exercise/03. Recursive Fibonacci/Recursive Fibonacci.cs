// The Fibonacci sequence is a quite famous sequence of numbers. Each member of the sequence is calculated from
// the sum of the two previous elements. The first two elements are 1, 1. Therefore the sequence goes like 1, 1, 2, 3, 5,
// 8, 13, 21, 34…
// The following sequence can be generated with an array, but that's easy, so your task is to implement recursively.
// So if the function GetFibonacci(n) returns the n
// th Fibonacci number we can express it using GetFibonacci(n)
// = GetFibonacci(n-1) + GetFibonacci(n-2).
// However, this will never end and in a few seconds, a StackOverflow Exception is thrown. For the recursion to stop, it
// has to have a “bottom”. The bottom of the recursion is GetFibonacci(2) should return 1 and
// GetFibonacci(1) should return 1.
// Input Format
// • On the only line in the input, the user should enter the wanted Fibonacci number.
// Output Format
// • The output should be the n
// th Fibonacci number counting from 1.
// Constraints
// • 1 ≤ N ≤ 50


using System;

namespace _03._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonaciLenght = new int[int.Parse(Console.ReadLine())];

            if (fibonaciLenght.Length >= 1 && fibonaciLenght.Length <= 50)
            {
                for (int i = 0; i < fibonaciLenght.Length; i++)
                {
                    fibonaciLenght[i] = 1;
                }

                for (int n = 1; n < fibonaciLenght.Length - 1; n++)
                {
                    fibonaciLenght[n + 1] = fibonaciLenght[n] + fibonaciLenght[n - 1];
                }
            }


            Console.WriteLine(fibonaciLenght[fibonaciLenght.Length - 1]);
        }

    }
}