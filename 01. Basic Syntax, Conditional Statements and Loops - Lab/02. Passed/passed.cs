// Create a program that receives a single number as an input representing a grade.
// Print in the console:

// • "Passed!" if the grade is equal or more than 3.00.

//            Input

// The input comes as a single floating-point number.

//            Output

// The output is either "Passed!" if the grade is equal or more than 3.00, otherwise you should print nothing.

using System;

namespace _02._Passed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade>= 3.00 )
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}