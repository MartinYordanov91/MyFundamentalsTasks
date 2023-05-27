// Create a program that receives three real numbers and sorts them in descending order. Print each number on a new
// line.


using System;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] number = new int[3];

            for (int i = 0; i <= 2; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(number);
            Array.Reverse(number);

            foreach (int i in number)
            {
                Console.WriteLine(i);
            }
            
            
        }
    }
}