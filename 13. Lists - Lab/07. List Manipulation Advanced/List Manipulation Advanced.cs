// Next, we are going to implement more complicated list commands, extending the previous task. Again, read a list
// and keep reading commands until you receive "end":
// • Contains {number} – check if the list contains the number and if so - print "Yes", otherwise print
// "No such number".
// • PrintEven – print all the even numbers, separated by a space.
// • PrintOdd – print all the odd numbers, separated by a space.
// • GetSum – print the sum of all the numbers.
// • Filter {condition} {number} – print all the numbers that fulfill the given condition. The condition
// will be either '<', '>', ">=", "<=".
// After the end command, print the list only if you have made some changes to the original list. Changes are made
// only from the commands from the previous task.



using System;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            bool flag = false;

            string consoleInput = Console.ReadLine();
            while (consoleInput != "end")
            {

                string[] comands = consoleInput.Split().ToArray();
                if (comands[0] == "Add")
                {
                    integerList.Add(int.Parse(comands[1]));
                    flag = true;
                }
                else if (comands[0] == "Remove")
                {
                    integerList.Remove(int.Parse(comands[1]));
                    flag = true;
                }
                else if (comands[0] == "RemoveAt")
                {
                    integerList.RemoveAt(int.Parse(comands[1]));
                    flag = true;
                }
                else if (comands[0] == "Insert")
                {
                    integerList.Insert((int.Parse(comands[2])), (int.Parse(comands[1])));
                    flag = true;
                }
                else if (comands[0] == "Contains")
                {
                    if (integerList.Contains(int.Parse(comands[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (comands[0] == "PrintEven")
                {

                    for (int i = 0; i < integerList.Count; i++)
                    {
                        if (integerList[i] % 2 == 0)
                        {
                            Console.Write(integerList[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (comands[0] == "PrintOdd")
                {

                    for (int i = 0; i < integerList.Count; i++)
                    {
                        if (integerList[i] % 2 != 0)
                        {
                            Console.Write(integerList[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (comands[0] == "GetSum")
                {
                    Console.WriteLine(integerList.Sum());
                }
                else if (comands[0] == "Filter")
                {
                    string condition = comands[1];
                    int number = int.Parse(comands[2]);

                    if (condition == "<")
                    {
                        foreach (var item in integerList)
                        {
                            if (item < number)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (condition == ">")
                    {
                        foreach (var item in integerList)
                        {
                            if (item > number)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (condition == "<=")
                    {
                        foreach (var item in integerList)
                        {
                            if (item <= number)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (condition == ">=")
                    {
                        foreach (var item in integerList)
                        {
                            if (item >= number)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        Console.WriteLine();
                    }

                }



                consoleInput = Console.ReadLine();
            }
            if (flag)
            {
                Console.WriteLine(string.Join(" ", integerList));
            }
        }
    }
}