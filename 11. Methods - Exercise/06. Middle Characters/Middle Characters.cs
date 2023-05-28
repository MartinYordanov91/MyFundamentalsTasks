// You will receive a single string. Create a method that prints the character found at its middle. If the length of the
// string is even, there are two middle characters.


using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";
            output = MiddleCharacters(input, output);
            Console.WriteLine(output);

        }

         static string MiddleCharacters(string input, string output)
        {
            if (input.Length % 2 == 0)
            {
                output += input[input.Length / 2 - 1];
                output += input[input.Length / 2];

            }
            else
            {
                output += input[input.Length / 2];
            }

            return output;
        }
    }
}