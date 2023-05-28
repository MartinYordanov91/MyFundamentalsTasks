// Read n numbers and print them in reverse order, separated by a single space.

using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengh =int.Parse(Console.ReadLine());
            int[] ints = new int[lengh];
            for (int i = 0; i < lengh; i++)
            {
                int input = int.Parse(Console.ReadLine());
                ints[i] = input;
            }
           

            Console.Write(string.Join(" ",ints.Reverse()));
        }
    }
}