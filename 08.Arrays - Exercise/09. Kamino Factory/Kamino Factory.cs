// The clone factory in Kamino got another order to clone troops. But this time you are tasked to find the best DNA
// sequence to use in the production.
// You will receive the DNA length and until you receive the command "Clone them!", you will be receiving a DNA
// sequence of ones and zeroes, split by '!' (one or several).
// You should select the sequence with the longest subsequence of ones. If there are several sequences with the same
// length of the subsequence of ones, print the one with the leftmoststarting index, if there are several sequences with
// the same length and starting index, select the sequence with the greater sum of its elements.
// After you receive the last command "Clone them!" you should print the collected information in the following
// format:
// "Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
// "{DNA sequence, joined by space}"
// Input / Constraints
// • The first line holds the length of the sequences – integer in the range [1…100].
// • On the next lines, until you receive "Clone them!", you will be receiving sequences (at least one) of ones
// and zeroes, split by '!' (one or several).
// Output
// The output should be printed on the console and consists of two lines in the following format:
// "Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
// "{DNA sequence, joined by space}"

using System;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main()
        {
            int index = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] bestDNA = new int[index];
            int bestLength = 0;
            int bestPosition = 0;
            int bestSum = 0;
            int curentDNA = 0, dnaIndex = 1;
            

            while (input != "Clone them!")
            {
                int position = 0;
                int count = 0, curentLength = 0;
                int curentSum = 0;
                curentDNA++;

                int[] array = input
                    .Split(separator: "!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != 1)
                    {
                        count = 0;
                        continue;
                    }
                    count++;

                    if (count > curentLength)
                    {
                        curentLength = count;
                        position = i;
                    }
                }
                position = position - curentLength + 1;

                curentSum = array.Sum();
                if (bestLength < curentLength ||
                    bestLength == curentLength && bestPosition > position ||
                    bestLength == curentLength && bestPosition == position && curentSum > bestSum)
                {
                    bestSum = curentSum;
                    bestPosition = position;
                    bestLength = curentLength;
                    bestDNA = array;
                    dnaIndex = curentDNA;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {dnaIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}