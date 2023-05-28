// Create a program that reads a list of integers. Then until you receive "end", you will receive different commands:
// • Add {number}: add a number to the end of the list.
// • Remove {number}: remove a number from the list.
// • RemoveAt {index}: remove a number at a given index.
// • Insert {number} {index}: insert a number at a given index.
// Note: All the indices will be valid!
// When you receive the "end" command, print the final state of the list (separated by spaces).


using System;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string consoleInput = Console.ReadLine();
            while (consoleInput != "end")
            {
                string[] comands = consoleInput.Split().ToArray();
                if (comands[0] == "Add")
                {
                    integerList.Add(int.Parse(comands[1]));
                }
                else if (comands[0] == "Remove")
                {
                    integerList.Remove(int.Parse(comands[1]));
                }
                else if (comands[0] == "RemoveAt")
                {
                    integerList.RemoveAt(int.Parse(comands[1]));
                }
                else if (comands[0] == "Insert")
                {
                    integerList.Insert((int.Parse(comands[2])), (int.Parse(comands[1])));
                }
                consoleInput = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", integerList));
        }
    }
}