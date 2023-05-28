// Create a method that receives a single string and prints out the number of vowels contained in it.

using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main()
        {
            string strInput = Console.ReadLine();

            Console.WriteLine(VowelsCount(strInput));
        }

        static int VowelsCount(string strInput)
        {
            int count = 0;
            for (int i = 0; i < strInput.Length; i++)
            {
                if (strInput[i] == 'A' || strInput[i] == 'a' ||
                    strInput[i] == 'E' || strInput[i] == 'e' ||
                    strInput[i] == 'I' || strInput[i] == 'i' ||
                    strInput[i] == 'O' || strInput[i] == 'o' ||
                    strInput[i] == 'U' || strInput[i] == 'u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}