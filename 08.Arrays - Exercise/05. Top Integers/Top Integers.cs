// Create a program to find all the top integers in an array. A top integer is an integer that is greater than all the
// elements to its right.

using System;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArry = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int position = 0;
            int num = 0;
            int outputInt = 0;


            for (int arry = 0; arry < intArry.Length; arry++)
            {
                num = intArry[arry];

                for (int fPosition = 0 + arry; fPosition < intArry.Length; fPosition++)
                {
                    if (num < intArry[fPosition])
                    {
                        position = fPosition;
                        num = intArry[fPosition];

                    }
                }
                if (num != outputInt)
                {
                    outputInt = num;

                    Console.Write($"{outputInt} ");
                }
            }

        }
    }
}