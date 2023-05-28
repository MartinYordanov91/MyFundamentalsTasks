// You are given a number num1, num2 and num3. Write a program that finds if num1 * num2 * num3 (the product)
// is negative, positive or zero. Try to do this WITHOUT multiplying the 3 numbers.

using System;

namespace _05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];

            FillArry(nums);
            PrintResult(nums);
        }

        private static void PrintResult(int[] nums)
        {
            if (nums.Any(x => x == 0))
            {
                Console.WriteLine("zero");
                return;
            }
            if (nums.Count(x => x < 0) % 2 == 1)
            {
                Console.WriteLine("negative");
            }
            else { Console.WriteLine("positive"); }
        }

        static void FillArry(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}