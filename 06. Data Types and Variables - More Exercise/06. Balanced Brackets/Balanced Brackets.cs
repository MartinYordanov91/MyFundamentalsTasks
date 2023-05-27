// You will receive n lines. On those lines, you will receive one of the following:
// • Opening bracket – '(',
// • Closing bracket – ')' or
// • Random string
// Your task is to find out if the brackets are balanced. That means after every closing bracket should follow an
// opening one. Nested parentheses are not valid and if two consecutive opening brackets exist, the expression
// should be marked as unbalanced. 
// Input
// • On the first line, you will receive n – the number of lines, which will follow.
// • On the next n lines, you will receive '(', ')' or another string.
// Output
// You have to print "BALANCED", if the parentheses are balanced and "UNBALANCED" otherwise.
// Constraints
// • n will be in the interval [1…20].
// • The length of the stings will be between [1…100] characters.

using System;

namespace _06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numLines = int.Parse(Console.ReadLine());
            int trueFalse = 0;

            for (int i = 0; i < numLines; i++)
            {
                string input = Console.ReadLine();
                char cr;
                if (char.TryParse(input, out cr))
                {
                    if ((cr == ')' && trueFalse == 0) ||(cr == '(' && trueFalse == 1))
                    {
                        trueFalse+=10;
                    }


                    if (cr == '(' ) { trueFalse++; }
                    else if (cr == ')') { trueFalse--; }
                }
            }

            Console.WriteLine(trueFalse == 0 ? "BALANCED" : "UNBALANCED");
            
        }
    }
}