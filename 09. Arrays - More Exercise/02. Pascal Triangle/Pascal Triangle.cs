// The triangle may be constructed in the following manner: In row 0 (the topmost row), there is a unique nonzero
// entry 1. Each entry of each subsequent row is constructed by adding the number above and to the left with the
// number above and to the right, treating blank entries as 0. For example, the initial number in the first (or any other)
// row is 1 (the sum of 0 and 1), whereas the numbers 1 and 3 in the third row are added to produce the number 4 in
// the fourth row.
// If you want more info about it: https://en.wikipedia.org/wiki/Pascal's_triangle
// Print each row element separated with whitespace.

using System;

namespace _02._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] intArray = new int[number + 1];
            int[] dublicateArray = new int[number + 1];

            intArray[1] = 1;
            Console.WriteLine(intArray[1]);

            for (int lian = 1; lian < number; lian++)
            {
                for (int i = 1; i <= number; i++)
                {
                    dublicateArray[i] = intArray[i];
                }

                for (int i = 1; i <= lian + 1; i++)
                {
                    intArray[i] = dublicateArray[i - 1] + dublicateArray[i];
                    Console.Write(intArray[i] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}