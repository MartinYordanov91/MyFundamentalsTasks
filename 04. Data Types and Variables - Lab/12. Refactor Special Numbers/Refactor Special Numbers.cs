// You are given a working code that is a solution to Problem 5. Special Numbers. However, the variables are
// improperly named, declared before they are needed and some of them are used for multiple purposes.
// Without using your previous solution, modify the code, so that it is easy to read and understand.

using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit = 0;

            for (int i = 1; i <= number; i++)
            {
                int copie = i;
                int sum = 0;

                while (copie > 0)
                {
                    digit = copie % 10;
                    sum += digit;
                    copie /= 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}