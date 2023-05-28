// Create a program, that reads a list of integers from the console and receives commands to manipulate the list.
// Your program may receive the following commands:
// • Delete {element} – delete all elements in the array, which are equal to the given element.
// • Insert {element} {position} – insert the element at the given position.
// You should exit the program when you receive the "end" command. Print all numbers in the array, separated by a
// single whitespace.

using System;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] comands = input.Split().ToArray();
                if (comands[0] == "Delete")
                {
                    int elementRemulve = int.Parse(comands[1]);
                    list.RemoveAll(x => x == elementRemulve);
                }
                else if (comands[0] == "Insert")
                {
                    list.Insert(int.Parse(comands[2]), int.Parse(comands[1]));
                }
                input = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}