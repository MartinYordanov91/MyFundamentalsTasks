// Create a program that receives an integer as an input. Print the 10 times table for this integer. See the examples
// below for more information.
// Output
// Print every row of the table in the following format:
// {theInteger} X {times} = {product}
// Constraints
// • The integer will be in the interval [1…100]

using System;

namespace _10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numInput = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numInput} X {i} = {numInput * i }");
            }
        }
    }
}
