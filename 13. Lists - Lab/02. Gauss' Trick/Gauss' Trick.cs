// Create a program that sums all numbers in a list in the following order:
// first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.

using System;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int repetition = list.Count / 2;

            for (int i = 0; i < repetition; i++)
            {
                list[i] += list[list.Count - 1];

                list.RemoveAt(list.Count - 1);

            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}