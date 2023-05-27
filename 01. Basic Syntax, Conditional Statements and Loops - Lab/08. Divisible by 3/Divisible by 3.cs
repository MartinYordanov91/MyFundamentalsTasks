// Create a program, which prints all the numbers from 1 to 100, that are divisible by 3. You have to use a single for
// loop. The program should not receive input.

using System;

namespace _08._Divisible_by_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i <= 100; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}