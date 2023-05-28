// Create a method that receives two characters and prints all the characters between them according to ASCII (on a
// single line).
// NOTE: If the second letter's ASCII value is less than that of the first one, then the two initial letters should be
// swapped.

using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            CharacterPrintRange(first, second);

        }

        static void CharacterPrintRange(char first, char second)
        {
            if (first < second)
            {
                SecondBiger(first, second);
            }
            else
            {
                FirstBiger(first, second);
            }
        }

        static void FirstBiger(char first, char second)
        {
            for (int i = second + 1; i < first; i++)
            {
                Console.Write((char)i + " ");
            }
        }

        static void SecondBiger(char first, char second)
        {
            for (int i = first + 1; i < second; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}