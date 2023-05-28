// Anonymous has created a cyber hyper virus, which steals data from the CIA. You, as the lead security developer in the
// CIA, have been tasked to analyze the software of the virus and observe its actions on the data. The virus is known for
// its innovative and unbelievably clever technique of merging and dividing data into partitions.
// You will receive a single input line, containing strings, separated by spaces. The strings may contain any ASCII
// character except whitespace. Then you will begin receiving commands in one of the following formats:
// • merge {startIndex} {endIndex}
// • divide {index} {partitions}
// Every time you receive the merge command, you must merge all elements from the startIndex to the endIndex.
// In other words, you should concatenate them.
// Example: {abc, def, ghi} -> merge 0 1 -> {abcdef, ghi}
// If any of the given indexes is out of the array, you must take only the range that is inside the array and merge it.
// Every time you receive the divide command, you must divide the element at the given index, into several small
// substrings with equal length. The count of the substrings should be equal to the given partitions.
// Example: {abcdef, ghi, jkl} -> divide 0 3 -> {ab, cd, ef, ghi, jkl}
// If the string cannot be exactly divided into the given partitions, make all partitions except the last with equal
// lengths and make the last one – the longest.
// Example: {abcd, efgh, ijkl} -> divide 0 3 -> {a, b, cd, efgh, ijkl}
// The input ends when you receive the command "3:1". At that point, you must print the resulting elements, joined
// by a space.
// Input
// • The first input line will contain the array of data.
// • On the next several input lines, you will receive commands in the format specified above.
// • The input ends when you receive the command "3:1".
// Output
// • As output, you must print a single line containing the elements of the array, joined by a space.
// Constrains
// • The strings in the array may contain any ASCII character except whitespace.
// • The startIndex and the endIndex will be in the range [-1000…1000].
// • The endIndex will always be greater than the startIndex.
// • The index in the divide command will always be inside the array.
// • The partitions will be in the range [0…100].
// • Allowed working time/memory: 100ms / 16MB.

using System;
using System.Collections.Generic;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputStringList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string consoleInput = Console.ReadLine();

            while (consoleInput != "3:1")
            {
                string[] comand = consoleInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();


                if (comand[0] == "merge")
                {
                    int startIndex = int.Parse(comand[1]);
                    int endIndex = int.Parse(comand[2]);

                    if (startIndex < 0) startIndex = 0;
                    if (endIndex >= inputStringList.Count) endIndex = inputStringList.Count - 1;
                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        inputStringList[startIndex] += inputStringList[startIndex + 1];
                        inputStringList.RemoveAt(startIndex + 1);
                    }
                }
                else if (comand[0] == "divide")
                {
                    int index = int.Parse(comand[1]);
                    int partitions = int.Parse(comand[2]);
                    string copyIndexElement = inputStringList[index];
                    inputStringList.RemoveAt(index);

                    List<char> elementCharArrey = copyIndexElement.ToList();
                    List<string> divideElements = new List<string>();
                    int count = elementCharArrey.Count / partitions;

                    if (elementCharArrey.Count % partitions == 0)
                    {
                        for (int i = 0; i < partitions; i++)
                        {
                            string curentElement = "";

                            for (int j = 0; j < count; j++)
                            {
                                curentElement += elementCharArrey[j];
                            }

                            elementCharArrey.RemoveRange(0, count);
                            divideElements.Add(curentElement);
                        }

                        for (int n = 0; n < partitions; n++)
                        {
                            inputStringList.Insert(index, divideElements[divideElements.Count - 1]);
                            divideElements.RemoveAt(divideElements.Count-1);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < partitions - 1; i++)
                        {
                            string curentElement = "";

                            for (int j = 0; j < count; j++)
                            {
                                curentElement += elementCharArrey[j];
                            }

                            elementCharArrey.RemoveRange(0, count);
                            divideElements.Add(curentElement);
                        }
                        string lastCharakters = "";
                        for (int m = 0; m < elementCharArrey.Count; m++)
                        {
                            lastCharakters += elementCharArrey[m];
                        }
                        divideElements.Add(lastCharakters);
                        elementCharArrey.RemoveRange(0 , elementCharArrey.Count-1);

                        for (int n = 0; n < partitions; n++)
                        {
                            inputStringList.Insert(index, divideElements[divideElements.Count - 1]);
                            divideElements.RemoveAt(divideElements.Count - 1);
                        }
                    }
                }

                consoleInput = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", inputStringList));
        }
    }
}