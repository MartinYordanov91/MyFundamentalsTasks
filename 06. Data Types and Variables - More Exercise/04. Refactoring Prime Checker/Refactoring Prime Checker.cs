// You are given a program that checks if numbers in a given range [2...N] are prime. For each number is printed
// "{number} -> {true or false}". The code, however, is not very well written. Your job is to modify it in a way
// that is easy to read and understand.

using System;

namespace _04._Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberRange = int.Parse(Console.ReadLine());

            for (int num = 2; num <= numberRange; num++)
            {
                bool arPrime = true;

                for (int checking = 2; checking < num; checking++)
                {
                    if (num % checking == 0)
                    {
                        arPrime = false;
                        break;
                    }
                }
                if (arPrime)
                    Console.WriteLine("{0} -> {1}", num, "true");
                else
                    Console.WriteLine("{0} -> {1}", num, "false");
            }
        }
    }
}