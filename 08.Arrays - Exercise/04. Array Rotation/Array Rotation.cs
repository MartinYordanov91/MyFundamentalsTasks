// Create a program that receives an array and several rotations that you have to perform. The rotations are done by
// moving the first element of the array from the front to the back. Print the resulting array.


using System;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intsArry = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rotationNum = int.Parse(Console.ReadLine());
            int first, second, last;

            for (int i = 0; i < rotationNum; i++)
            {
                first = intsArry[0];

                for (int f = 0; f < intsArry.Length-1; f++)
                {
                    intsArry[f] = intsArry[f+1];
                }

                intsArry[intsArry.Length-1] = first;
            }

            Console.WriteLine(string.Join(" " , intsArry));
        }
    }
}