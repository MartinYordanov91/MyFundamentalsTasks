// Every time John tries to pay the bills he sees on the cash desk the sign: "I will be back in 30 minutes".
// One day John was tired of waiting and decided he needed a program, which prints the time after 30 minutes, so he
// could come back after exactly 30 minutes. He is not able to write the program by himself, so he asks for help.
// Input
// Two numbers are read from the console:
// • The first number is hours and will be between 0 and 23.
// // • The second number is minutes and will be between 0 and 59.
// Output
// Print on the console the time after 30 minutes. The result should be in format hh:mm. The hours may contain one
// or two numbers and the minutes always have two numbers (with leading zero).

using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hh = int.Parse(Console.ReadLine());
            int mm = int.Parse(Console.ReadLine());

            int time = hh * 60 + mm + 30;

            hh = time / 60;
            mm = time % 60;

            if (hh == 24 && mm > 0)
            {
                hh = 0;
            }
            if (mm > 9)
                Console.WriteLine($"{hh}:{mm}");
            else
                Console.WriteLine($"{hh}:0{mm}");
        }
    }
}