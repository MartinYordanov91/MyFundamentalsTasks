// You will be given a list of numbers and a string. For each element of the list you must calculate the sum of its digits
// and take the element, corresponding to that index from the text. If the index is greater than the length of the text,
// start counting from the beginning (so that you always have a valid index). After you get that element from the text,
// you must remove the character you have taken from it (so for the next index the text will be with one
// characterless).

using System;

namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integerlist = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<char> characterList = Console.ReadLine().ToList();
            string output = "";

            for (int i = 0; i < integerlist.Count; i++)
            {
                int curentElement = integerlist[i];
                int charaterIndex = 0;

                while (curentElement > 0)
                {
                    charaterIndex += curentElement % 10;
                    curentElement /= 10;
                }

                if (charaterIndex > characterList.Count - 1)
                {
                    int listLenght = characterList.Count ;
                    charaterIndex%= listLenght;

                    output += characterList[charaterIndex ];
                    characterList.RemoveAt(charaterIndex );
                }
                else
                {
                    output += characterList[charaterIndex];
                    characterList.RemoveAt(charaterIndex);
                }

            }

            Console.WriteLine(output);
        }
    }
}