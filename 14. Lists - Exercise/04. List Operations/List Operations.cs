// The first input line will hold a list of integers. Until we receive the "End" command, we will be given operations we
// have to apply to the list.
// The possible commands are:
// • Add {number} – add the given number to the end of the list
// • Insert {number} {index} – insert the number at the given index
// • Remove {index} – remove the number at the given index
// • Shift left {count} – first number becomes last. This has to be repeated the specified number of times
// • Shift right {count} – last number becomes first. To be repeated the specified number of times
// Note: the index given may be outside of the bounds of the array. In that case print: "Invalid index".


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listIntegers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string comand = Console.ReadLine();

            while (comand != "End")
            {
                string[] operationComand = comand.Split().ToArray();

                if (operationComand[0] == "Add")
                {
                    //    • Add { number} – add the given number to the end of the list
                    listIntegers.Add(int.Parse(operationComand[1]));
                }
                else if (operationComand[0] == "Insert")
                {
                    //    • Insert {number} { index} – insert the number at the given index
                    if (listIntegers.Count < int.Parse(operationComand[2]) || int.Parse(operationComand[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        listIntegers.Insert(int.Parse(operationComand[2]), int.Parse(operationComand[1]));
                    }
                }
                else if (operationComand[0] == "Remove")
                {
                    //    • Remove {index} – remove the number at the given index
                    if (listIntegers.Count < int.Parse(operationComand[1]) || int.Parse(operationComand[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        listIntegers.RemoveAt(int.Parse(operationComand[1]));
                    }
                }
                else if (operationComand[0] == "Shift")
                {
                    if (operationComand[1] == "left")
                    {
                           // • Shift left { count} – first number becomes last. This has to be repeated the specified number of times
                        for (int i = 0; i < int.Parse(operationComand[2]); i++)
                        {
                            listIntegers.Add(listIntegers[0]);
                            listIntegers.RemoveAt(0);
                        }

                    }
                    else if (operationComand[1] == "right")
                    {
                        //    • Shift right {count} – last number becomes first. To be repeated the specified number of times
                        for (int i = 0; i < int.Parse(operationComand[2]); i++)
                        {
                            listIntegers.Insert(0, listIntegers[listIntegers.Count - 1]);
                            listIntegers.RemoveAt(listIntegers.Count - 1);
                        }
                    }
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", listIntegers));
        }
    }
}







//     Note: the index given may be outside of the bounds of the array. In that case print: "Invalid index".