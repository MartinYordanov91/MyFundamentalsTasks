// Create a program that multiplies the sum of all even digits of a number by the sum of all odd digits of the same
// number:
// • Create a method called GetMultipleOfEvenAndOdds()
// • Create a method GetSumOfEvenDigits()
// • Create GetSumOfOddDigits()
// • You may need to use Math.Abs() for negative numbers

using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int[] ints = Array.ConvertAll(number.ToString().ToArray(), x => (int)x - 48);


            int even = 0, odd = 0;
            EvenOddSum(ints, ref even, ref odd);

            Console.WriteLine(even * odd);
        }

        static void EvenOddSum(int[] ints, ref int even, ref int odd)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 != 0)
                {
                    odd += ints[i];
                }
                else
                {
                    even += ints[i];
                }
            }
        }
    }
}