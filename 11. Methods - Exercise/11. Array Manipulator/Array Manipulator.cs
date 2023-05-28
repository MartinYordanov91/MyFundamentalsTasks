// Peter has finally become a junior developer and has received his first task. It's about manipulating an array of
// integers. He is not quite happy about it, since he hates manipulating arrays. They are going to pay him a lot of
// money, though, and he is willing to give somebody half of it if they help him do his job. You, on the other hand, love
// arrays (and money), so you decide to try your luck.
// The array may be manipulated by one of the following commands
// • exchange {index} – splits the array after the given index and exchanges the places of the two resulting
// sub-arrays. E.g. [1, 2, 3, 4, 5] -> exchange 2 -> result: [4, 5, 1, 2, 3]
// o If the index is outside the boundaries of the array, print "Invalid index"
// • max even/odd – returns the INDEX of the max even/odd element -> [1, 4, 8, 2, 3] -> max odd -> print 4
// • min even/odd – returns the INDEX of the min even/odd element -> [1, 4, 8, 2, 3] -> min even > print 3
// o If there are two or more equal min/max elements, return the index of the rightmost one
// o If a min/max even/odd element cannot be found, print "No matches"
// • first {count} even/odd – returns the first {count} elements -> [1, 8, 2, 3] -> first 2 even -> print [8,
// 2]
// • last {count} even/odd – returns the last {count} elements -> [1, 8, 2, 3] -> last 2 odd -> print [1, 3]
// o If the count is greater than the array length, print "Invalid count"
// o If there are not enough elements to satisfy the count, print as many as you can. If there are zero
// even/odd elements, print an empty array "[]"
// • end – stop taking input and print the final state of the array
// Input
// • The input data should be read from the console.
// • On the first line, the initial array is received as a line of integers, separated by a single space.
// • On the next lines, until the command "end" is received, you will receive the array manipulation commands.
// • The input data will always be valid and in the format described. There is no need to check it explicitly.
// Output
// • The output should be printed on the console.
// • On a separate line, print the output of the corresponding command.
// • On the last line print the final array in square brackets with its elements separated by a comma and a space .
// • See the examples below to get a better understanding of your task.
// Constraints
// • The number of input lines will be in the range [2…50].
// • The array elements will be integers in the range [0…1000].
// • The number of elements will be in the range [1…50].
// • The split index will be an integer in the range [-2
// 31…231 – 1].
// • The first/last count will be an integer in the range [1…2
// 31 – 1].
// • There will not be redundant whitespace anywhere in the input.
// • Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string arrayComand = "";

            while ((arrayComand = Console.ReadLine()) != "end")
            {
                if (arrayComand.StartsWith("exchange"))
                {
                    intArray = ExchangeIntegerArray(intArray, arrayComand);
                }
                else if (arrayComand.StartsWith("max"))
                {
                    MaxElementsForCondition(intArray, arrayComand);
                }
                else if (arrayComand.StartsWith("min"))
                {
                    MinElementForCondition(intArray, arrayComand);
                }
                else if (arrayComand.StartsWith("first"))
                {
                    FirstElementsForCondition(intArray, arrayComand);
                }
                else if (arrayComand.StartsWith("last"))
                {
                    LastElementsForCondition(intArray, arrayComand);
                }

            }

            Console.WriteLine("[{0}]", string.Join(", ", intArray));

        }

        static int[] ExchangeIntegerArray(int[] intArray, string arrayComand)
        {
            int index = int.Parse(arrayComand.Split().Last());

            if (index >= intArray.Length || index < 0)
            {
                Console.WriteLine("Invalid index");

            }
            else
            {
                intArray = Exchange(intArray, index);

            }

            return intArray;
        }
        static void LastElementsForCondition(int[] intArray, string arrayComand)
        {
            string[] inputs = arrayComand.Split();
            int count = int.Parse(inputs[1]);

            if (arrayComand.Contains("even"))
            {
                if (count <= intArray.Length)
                {
                    int[] result = intArray.Where(x => x % 2 == 0)
                        .TakeLast(count).ToArray();
                    Console.WriteLine("[{0}]", string.Join(", ", result));
                }
                else { Console.WriteLine("Invalid count"); }
            }
            else if (arrayComand.Contains("odd"))
            {
                if (count <= intArray.Length)
                {
                    int[] result = intArray.Where(x => x % 2 == 1)
                        .TakeLast(count).ToArray();
                    Console.WriteLine("[{0}]", string.Join(", ", result));
                }
                else { Console.WriteLine("Invalid count"); }
            }
        }

        static void FirstElementsForCondition(int[] intArray, string arrayComand)
        {
            string[] inputs = arrayComand.Split();
            int count = int.Parse(inputs[1]);

            if (arrayComand.Contains("even"))
            {
                if (count <= intArray.Length)
                {
                    int[] result = intArray.Where(x => x % 2 == 0)
                        .Take(count).ToArray();
                    Console.WriteLine("[{0}]", string.Join(", ", result));
                }
                else { Console.WriteLine("Invalid count"); }
            }
            else if (arrayComand.Contains("odd"))
            {
                if (count <= intArray.Length)
                {
                    int[] result = intArray.Where(x => x % 2 == 1)
                        .Take(count).ToArray();
                    Console.WriteLine("[{0}]", string.Join(", ", result));
                }
                else { Console.WriteLine("Invalid count"); }
            }
        }

        static void MinElementForCondition(int[] intArray, string arrayComand)
        {
            if (arrayComand.Contains("even"))
            {
                if (intArray.Any(x => x % 2 == 0))
                {
                    int min = intArray.Where((x => x % 2 == 0)).Min();
                    Console.WriteLine(Array.LastIndexOf(intArray, min));
                }
                else { Console.WriteLine("No matches"); }
            }
            else if (arrayComand.Contains("odd"))
            {
                if (intArray.Any(x => x % 2 == 1))
                {
                    int min = intArray.Where((x => x % 2 == 1)).Min();
                    Console.WriteLine(Array.LastIndexOf(intArray, min));
                }
                else { Console.WriteLine("No matches"); }
            }
        }

        static void MaxElementsForCondition(int[] intArray, string arrayComand)
        {
            if (arrayComand.Contains("even"))
            {
                if (intArray.Any(x => x % 2 == 0))
                {
                    int max = intArray.Where((x => x % 2 == 0)).Max();
                    Console.WriteLine(Array.LastIndexOf(intArray, max));
                }
                else { Console.WriteLine("No matches"); }

            }
            else if (arrayComand.Contains("odd"))
            {
                if (intArray.Any(x => x % 2 == 1))
                {
                    int max = intArray.Where((x => x % 2 == 1)).Max();
                    Console.WriteLine(Array.LastIndexOf(intArray, max));
                }
                else { Console.WriteLine("No matches"); }
            }
        }

        static int[] Exchange(int[] intArray, int index)
        {
            return intArray.Skip(index+1).Take(intArray.Length - index)
                 .Concat(intArray.Take(index+1)).ToArray();

        }
    }
}