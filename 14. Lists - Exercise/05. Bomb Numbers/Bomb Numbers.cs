// Create a program that reads a sequence of numbers and a special bomb number holding a certain power. Your task
// is to detonate every occurrence of the special bomb number and according to its power the numbers to its left and
// right. The bomb power refers to how many numbers to the left and right will be removed, no matter their values.
// Detonations are performed from left to right and all the detonated numbers disappear. Finally, print the sum of the
// remaining elements in the sequence.


using System;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> comandList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            
            while (numbersList.Contains(comandList[0]))
            {
                int bomb = comandList[0];
                int power = comandList[1];
                int index = numbersList.IndexOf(bomb);

                if (numbersList.Count > index + power)
                {
                    for (int i = index + 1; i < index + power + 1; i++)
                    {
                        numbersList.RemoveAt(index + 1);
                    }
                }
                else
                {
                    for (int i = index + 1; i < numbersList.Count; i++)
                    {
                        numbersList.RemoveAt(index + 1);
                    }
                }

                if (index - power >= 0)
                {
                    for (int i = index; i >= index - power; i--)
                    {
                        numbersList.RemoveAt(i);
                    }
                }
                else
                {
                    for (int i = index; i >= 0; i--)
                    {
                        numbersList.RemoveAt(i);
                    }
                }
            }
            Console.WriteLine(numbersList.Sum());
        }
    }
}