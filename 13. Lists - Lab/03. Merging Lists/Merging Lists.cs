// You are going to receive two lists of numbers. Create a list that contains the numbers from both of the lists. The
// first element should be from the first list, the second from the second list, and so on. If the length of the two lists is
// not equal, just add the remaining elements at the end of the list.

using System;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstListOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondListOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> containsListResult = new List<int>();

            int longerListCount = FirstOrSecond(firstListOfNumbers, secondListOfNumbers);

            for (int i = 0; i < longerListCount; i++)
            {
                if (i < firstListOfNumbers.Count)
                {
                    containsListResult.Add(firstListOfNumbers[i]);
                }
                if (i < secondListOfNumbers.Count)
                {
                    containsListResult.Add(secondListOfNumbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", containsListResult));
        }

        static int FirstOrSecond(List<int> firstListOfNumbers, List<int> secondListOfNumbers)
        {
            int lenght = 0;

            if (firstListOfNumbers.Count > secondListOfNumbers.Count)
            {
                lenght = firstListOfNumbers.Count;
            }
            else
            {
                lenght = secondListOfNumbers.Count;
            }
            return lenght;
        }
    }
}