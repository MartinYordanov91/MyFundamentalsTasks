// Write a program that mixes up two lists by some rules. You will receive two lines of input, each one being a list of
// numbers. The mixing rules are:
// • Start from the beginning of the first list and the ending of the second.
// • Add element from the first and element from the second.
// • In the end, there will always be a list, in which there are 2 elements are remaining.
// • These elements will be the range of the elements you need to print.
// • Loop through the result list and take only the elements that fulfill the condition.
// • Print the elements ordered in ascending order and separated by a space.

using System;

namespace _04._Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstIntList = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            List<int> secondIntList = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            secondIntList.Reverse();

            List<int> mixedIntList = new List<int>();
            bool firstIsShort = true;
            int shorterList;

            if (firstIntList.Count < secondIntList.Count)
            {
                shorterList = firstIntList.Count;
                firstIsShort = true;
            }
            else
            {
                shorterList = secondIntList.Count;
                firstIsShort= false;
            }

            for (int i = 0; i < shorterList; i++)
            {
                mixedIntList.Add(firstIntList[0]);
                firstIntList.RemoveAt(0);
                mixedIntList.Add(secondIntList[0]);
                secondIntList.RemoveAt(0);

            }

            if(secondIntList.Count> 0 ) { secondIntList.Reverse(); }
            int bierNum= 0;
            int lowNum = 0;

            if (!firstIsShort)
            {
                if (firstIntList[0] > firstIntList[1])
                {
                    bierNum = firstIntList[0];
                    lowNum = firstIntList[1];
                }
                else
                {
                    bierNum = firstIntList[1];
                    lowNum = firstIntList[0];
                }

            }
            else if(firstIsShort)
            {
                if (secondIntList[0] > secondIntList[1])
                {
                    bierNum = secondIntList[0];
                    lowNum = secondIntList[1];
                }
                else
                {
                    bierNum = secondIntList[1];
                    lowNum = secondIntList[0];
                }
            }

            List<int> outPutList = new List<int>();

            for (int i = 0; i < mixedIntList.Count; i++)
            {
                int curentNum = mixedIntList[i];
                if (curentNum < bierNum && curentNum > lowNum)
                {
                    outPutList.Add(curentNum);
                }
            }
            outPutList.Sort();

            Console.WriteLine(string.Join(" ", outPutList));

        }
    }
}