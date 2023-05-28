// Create a program to read an array of integers and condense them by summing all adjacent couples of elements
// until a single integer remains.
// For example, let us say we have 3 elements - {2, 10, 3}. We sum the first two and the second two elements and
// get {2 + 10, 10 + 3} = {12, 13}, then we sum all adjacent elements again. This results in {12 + 13} =
// {25}.


using System;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArry = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < intArry.Length -1; i++)
            {
                for (int n = 0; n < intArry.Length - 1; n++)
                {
                    intArry[n] += intArry[n+1];
                }
            }

            Console.WriteLine(intArry[0]);
        }
    }
}