// Read an array of 4*k integers, fold it like shown below, and print the sum of the upper and lower two rows (each
// holding 2*k integers)

using System;

namespace _04._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumber = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            List<int> outpuNumbers = new List<int>();
            List<int> helperList = new List<int>();

            int halfArrayLenght = arrayOfNumber.Length / 2;

            for (int i = halfArrayLenght / 2 - 1; i >= 0; i--)
            {
                outpuNumbers.Add(arrayOfNumber[i]);
            }

            for (int m = arrayOfNumber.Length - 1; m >= halfArrayLenght + halfArrayLenght / 2; m--)
            {
                outpuNumbers.Add(arrayOfNumber[m]);
            }


            for (int n = halfArrayLenght / 2 ; n < halfArrayLenght + halfArrayLenght / 2; n++)
            {
                helperList.Add(arrayOfNumber[n]);
            }

            for (int c = 0; c < outpuNumbers.Count; c++)
            {
                outpuNumbers[c] += helperList[c]; 
            }

            Console.WriteLine(string.Join(" ", outpuNumbers));
        }
    }
}