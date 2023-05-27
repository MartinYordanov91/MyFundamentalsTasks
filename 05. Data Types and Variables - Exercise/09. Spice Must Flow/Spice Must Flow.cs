// Spice is Love, Spice is Life. And most importantly, Spice must flow. It must be extracted from the scorching sands of
// Arrakis, under the constant threat of giant sandworms. To make the work as efficient as possible, the Duke has
// tasked you with the creation of management software.
// Create a program that calculates the total amount of spice that can be extracted from a source. The source has a
// starting yield, which indicates how much spice can be mined on the first day. After it has been mined for a day, the
// yield drops by 10, meaning on the second day it'll produce 10 less spice than on the first, on the third day 10 less
// than on the second, and so on (see examples). A source is considered profitable only while its yield is at least 100 –
// when less than 100 spices are expected in a day, abandon the source.
// The mining crew consumes 26 spices every day at the end of their shift and an additional 26 after the mine has been
// exhausted. Note that the workers cannot consume more spice than there is in storage.
// When the operation is complete, print on the console, on two separate lines, how many days the mine has operated
// and the total amount of spice extracted.
// Input
// You will receive a number, representing the starting yield of the source.
// Output
// Print on the console, on two separate lines, how many days the mine has operated and the total amount of spice
// extracted.
// Constraints
// • The starting yield will be a positive integer within the range [0…2147483647].

using System;
using System.Numerics;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seasoningPerDay = int.Parse(Console.ReadLine());
            int sumSpiceSeasoning = 0;
            int dayCond = 0;

            while (seasoningPerDay >= 100)
            {
                sumSpiceSeasoning += seasoningPerDay;
                sumSpiceSeasoning -= 26;
                seasoningPerDay -= 10;
                dayCond++;
            }
            sumSpiceSeasoning -= 26;
            if (sumSpiceSeasoning < 0) { sumSpiceSeasoning = 0; }

            Console.WriteLine(dayCond);
            Console.WriteLine(sumSpiceSeasoning);

        }
    }
}