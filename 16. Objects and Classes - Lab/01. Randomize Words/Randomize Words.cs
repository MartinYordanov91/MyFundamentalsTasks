// You will be given a string that will contain words separated by a single space. Randomize their order and print each
// word on a new line.
// Hints
// • Split the input string by (space) and create an array of words.
// • Create a random number generator – an object rnd of type Random.
// • In a for loop exchange each number at positions 0, 1,…,words.Length-1 by a number at random
// position. To generate a random number in range use rnd.Next(minValue, maxValue). Note that by
// definition minValue is inclusive, but maxValue is exclusive.
// • Print each word in the array on new line.

using System;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            Random random = new Random();


            for (int i = 0; i < input.Count; i++)
            {
                int randomIndex = random.Next(0, input.Count);

                string curentWord = input[i];
                string randomWord = input[randomIndex];


                input[i] = randomWord;
                input[randomIndex] = curentWord;
            }
            Console.WriteLine(string.Join(Environment.NewLine , input));
        }
    }
}