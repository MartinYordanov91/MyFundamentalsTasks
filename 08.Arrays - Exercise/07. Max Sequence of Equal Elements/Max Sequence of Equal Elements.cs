// Create a program that finds the longest sequence of equal elements in an array of integers. If several equal
// sequences are present in the array, print out the leftmost one.


using System;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arryInt = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int count = 1;
            int topCount = 0;
            int position = 0;
            int number = 0;

            for (int i = 0; i < arryInt.Length - 1; i++)
            {
                if (arryInt[i] == arryInt[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > topCount)
                {
                    topCount = count;
                    position = i;
                    number = arryInt[i];
                }
            }
            for (int f = position - topCount; f < position; f++)
            {
                Console.Write(number + " ");
            }

        }
    }
}