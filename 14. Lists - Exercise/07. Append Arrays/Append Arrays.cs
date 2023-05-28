// Create a program to append several arrays of numbers one after another.
// • Arrays are separated by '|'
// • Their values are separated by spaces (' ', one or several)
// • Take all arrays starting from the rightmost and going to the left and place them in a new array in that order

using System;
using System.ComponentModel;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> readStringInput = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();

            readStringInput.Reverse();

            string listToString = " ";

            for (int i = 0; i < readStringInput.Count; i++)
            {
                listToString += readStringInput[i] + " ";
            }

            List<int> stringToIntList = listToString.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Console.WriteLine(string.Join(" ", stringToIntList));
            
        }
    }
}