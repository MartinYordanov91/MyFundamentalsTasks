// You will be given two hands of cards, which will be represented by integers. Assume each one is held by a different
// player. You have to find which one has the winning deck. You start from the beginning of both hands of cards.
// Compare the cards from the first deck to the cards from the second deck. The player, who holds the more powerful
// card on the current iteration, takes both cards and puts them at the back of his hand - the second player's card is
// placed last and the first person's card (the winning one) comes after it (second to last). If both players' cards have
// the same values - no one wins and the two cards must be removed from both hands. The game is over only when 
// one of the decks is left without any cards. You have to display the result on the console and the sum of the
// remaining cards: "{First/Second} player wins! Sum: {sum}".

using System;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (first.Count > 0 && second.Count > 0)
            {
                if (first[0] > second[0])
                {
                    first.Add(second[0]);
                    first.Add(first[0]);
                    first.RemoveAt(0);
                    second.RemoveAt(0);

                }
                else if (first[0] < second[0])
                {
                    second.Add(first[0]);
                    second.Add(second[0]);
                    first.RemoveAt(0);
                    second.RemoveAt(0);
                }
                else
                {
                    first.RemoveAt(0);
                    second.RemoveAt(0);
                }
            }
            if (first.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {first.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {second.Sum()}");
            }
        }
    }
}