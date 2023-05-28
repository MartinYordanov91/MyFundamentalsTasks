// Create a program that prints out all common elements in two arrays. You have to compare the elements of the
// second array to the elements of the first.


using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstString = Console.ReadLine()
            .Split()
            .ToArray();
            string[] secondString = Console.ReadLine()
            .Split()
            .ToArray();
            string Output = "";

            for (int i = 0; i < secondString.Length; i++)
            {
                for (int f = 0; f < firstString.Length; f++)
                {
                    if (firstString[f] == secondString[i])
                    {
                        Output += firstString[f] + " ";
                    }
                }
            }
            Console.WriteLine(Output);

        }
    }
}