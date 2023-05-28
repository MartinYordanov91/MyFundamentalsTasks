// Write a program that reads a sequence of strings from the console. Encrypt every string by summing:
// • The code of each vowel multiplied by the string length
// • The code of each consonant divided by the string length
// Sort the number sequence in ascending order and print it in the console.
// On the first line, you will always receive the number of strings you have to read.


using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());

            string[] stringEncrypt = new string[arrayLength];
            int[] endSequence= new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                string input = Console.ReadLine();
                stringEncrypt[i] = input;
            }

            
            for (int j = 0; j < arrayLength; j++)
            {
                char[] curentIndex = stringEncrypt[j].ToCharArray();

                int curentIndexSum = 0;

                for (int y = 0; y < curentIndex.Length; y++)
                {
                    int sumChar = 0; 

                    if (curentIndex[y] == 'a' || curentIndex[y] == 'A' || curentIndex[y] == 'e' ||
                        curentIndex[y] == 'E' || curentIndex[y] == 'i' || curentIndex[y] == 'I' ||
                        curentIndex[y] == 'o' || curentIndex[y] == 'O' || curentIndex[y] == 'u' ||
                        curentIndex[y] == 'U')
                    {
                        sumChar = (int)curentIndex[y] * stringEncrypt[j].Length;
                    }
                    else
                    {
                        sumChar = (int)curentIndex[y] / stringEncrypt[j].Length;
                    }

                    curentIndexSum += sumChar;
                }
                endSequence[j] = curentIndexSum;
            }
            Array.Sort(endSequence);
            for (int m = 0; m < endSequence.Length; m++)
            {
                Console.WriteLine(endSequence[m]);
            }
        }
    }
}