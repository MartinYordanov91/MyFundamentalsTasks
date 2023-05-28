// Write a program to calculate the winner of a car race. You will receive an array of numbers. Each element of the
// array represents the time needed to pass through that step (the index). There are going to be two cars. One of
// them starts from the left side and the other one starts from the right side. The middle index of the array is the
// finish line. The number of elements in the array will always be odd. Calculate the total time for each racer to reach
// the finish, which is the middle of the array, and print the winner with his total time (the racer with less time). If
// you have a zero in the array, you have to reduce the time of the racer that reached it by 20% (from his current
// time).
// Print the result in the following format "The winner is {left/right} with total time: {total
// time}".


using System;

namespace _02._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToList();

            int raselenght = list.Count / 2;
            double left =  0;
            double right = 0;

            for (int l = 0; l < raselenght; l++)
            {
                if (list[l] != 0)
                {
                    left += list[l];
                }
                else
                {
                    left *= 0.8;
                }
            }

            for (int r = list.Count-1; r > raselenght; r--)
            {
                if (list[r] != 0)
                {
                    right += list[r];
                }
                else
                {
                    right*= 0.8;
                }
            }

            if (left < right)
            {
                Console.WriteLine($"The winner is left with total time: {left}");
            }
            else if (right < left) 
            {
                Console.WriteLine($"The winner is right with total time: {right}");
            }
        }
    }
}