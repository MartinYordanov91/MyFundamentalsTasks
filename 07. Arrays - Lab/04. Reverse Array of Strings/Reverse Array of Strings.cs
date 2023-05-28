// Create a program that reads an array of strings, reverses it, and prints its elements. The input consists of a sequence
// of space-separated strings. Print the output on a single line (space separated)

using System;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strArry = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < strArry.Length / 2; i++)
            {
                string first = strArry[i];
                string last = strArry[strArry.Length - 1 - i];
                strArry[i] = last;
                strArry[strArry.Length - 1 - i] = first;

            }
            Console.WriteLine(string.Join(" ",strArry));
        }
    }
}