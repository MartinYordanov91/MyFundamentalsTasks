// Create a program to sum all of the adjacent equal numbers in a list of decimal numbers, starting from left to right.
// • After two numbers are summed, the result could be equal to some of its neighbors and should be summed
// as well (see the examples below)
// • Always sum the leftmost two equal neighbors (if several couples of equal neighbors are available)

using System;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> integerList = Console.ReadLine()
                .Split().Select(double.Parse).ToList();
            int i = 0;

            while (i < integerList.Count -1)
            {
                if (integerList[i] == integerList[i + 1])
                {
                    integerList[i] += integerList[i + 1];

                    integerList.Remove(integerList[i + 1]);

                    i = 0;
                }
                else
                {
                    i++;
                }
            }
           

            Console.WriteLine(string.Join(" ", integerList));
            
        }
    }
}