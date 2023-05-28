// Enter a number in range 1-7 and print out the word representing it or "Invalid Day!". Use an array of strings.

using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int num =int.Parse(Console.ReadLine());

            Console.WriteLine(num > 0 && num < 8 ? dayOfWeek[num-1] : "Invalid day!") ;
            
            
        }
    }
}