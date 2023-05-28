// Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order. If
// there are no elements left in the list, print "empty".

using System;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arNumberPosetive = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

            for (int i = 0; i < arNumberPosetive.Count; i++)
            {
                if (arNumberPosetive[i] < 0)
                {
                    arNumberPosetive.RemoveAt(i);
                    i = -1;
                }
            }
            arNumberPosetive.Reverse();
            if (arNumberPosetive.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", arNumberPosetive));
            }
        }
    }
}