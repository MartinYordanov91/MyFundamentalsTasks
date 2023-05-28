// In the "Tribonacci" sequence, every number is formed by the sum of the previous 3 numbers.
// You are given a number num. Write a program that prints num numbers from the Tribonacci sequence, on a single
// line, starting from 1. The input comes as a parameter named num. The value num will always be a positive integer.


using System;

namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cycles = int.Parse(Console.ReadLine());

            int[] tribonachiNum = new int[cycles];

            if (cycles > 0 && cycles < 2) { tribonachiNum[0] = 1; }
            else if (cycles > 0 && cycles < 3) { tribonachiNum[0] = 1; tribonachiNum[1] = 1; }
            else if (cycles > 2)
            {
                tribonachiNum[0] = 1; tribonachiNum[1] = 1 ; tribonachiNum[2] = 2;
                for (int i = 3; i < cycles; i++)
                {
                    tribonachiNum[i] = tribonachiNum[i - 2] + tribonachiNum[i - 1] + tribonachiNum[i - 3];
                }
            }
            Console.WriteLine(string.Join(" " , tribonachiNum));
        }
    }
}