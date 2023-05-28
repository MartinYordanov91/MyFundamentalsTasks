// Create a program, which prints all unique pairs in an array of integers whose sum is equal to a given number.

using System;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arryInt = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int neadSum = int.Parse(Console.ReadLine());


            for (int fNum = 0; fNum < arryInt.Length; fNum++)
            {

                for (int sNum = fNum + 1; sNum < arryInt.Length; sNum++)
                {
                    if (arryInt[fNum] + arryInt[sNum] == neadSum)
                    {
                        Console.WriteLine($"{arryInt[fNum]} {arryInt[sNum]}");

                    }
                }
            }
        }
    }
}