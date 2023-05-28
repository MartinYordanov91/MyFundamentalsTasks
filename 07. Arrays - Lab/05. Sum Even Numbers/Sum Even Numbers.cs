// Read an array from the console and sum only its even values.

using System;

namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArry = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            for (int i = 0; i < intArry.Length; i++)
            {
               if (intArry[i] % 2 == 0)
                {
                    sum += intArry[i];
                }
            }
            Console.WriteLine(sum);
            
        }
    }
}
