// Create a program that receives an integer and prints the matching month. If the number is more than 12 or less
// than 1, print "Error!".
// Input
// You will receive a single integer on a single line.
// Output
// If the number is within the boundaries, print the corresponding month, otherwise print "Error!".

using System;


namespace _05._Month_Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] monthNames =
            {
              "January ","February","March","April","May","June","July","August","September","October","November","December"
            };

            int curentmonth = int.Parse(Console.ReadLine());

            if (curentmonth > 0 && curentmonth < 13)
            {
                Console.WriteLine(monthNames[curentmonth - 1]);
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }
    }
}