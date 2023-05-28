// Create a program that creates 2 arrays. You will be given an integer n. On the next n lines, you will get 2 integers.
// Form 2 new arrays in a zig-zag pattern as shown below

using System;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main()
        {
            int repetition = int.Parse(Console.ReadLine());

            int[] firstIntArry = new int[repetition];
            int[] secondIntArry = new int[repetition];

            for (int i = 0; i < repetition; i++)
            {
                int[] inputNum = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    firstIntArry[i] = inputNum[0];
                    secondIntArry[i] = inputNum[1];
                }
                else
                {
                    secondIntArry[i] = inputNum[0];
                    firstIntArry[i] = inputNum[1];  
                }
            }
            Console.WriteLine(string.Join(" " , firstIntArry));
            Console.WriteLine(string.Join(" " , secondIntArry));
        }
    }
}