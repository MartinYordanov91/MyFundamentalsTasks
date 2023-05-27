// Create a program, which helps you buy the games. The valid games are the following games in this table:
// Name                Price
// OutFall 4           $39.99
// CS: OG             $15.99
// Zplinter Zell      $19.99
// Honored 2          $59.99
// RoverWatch         $29.99
// RoverWatch Origins Edition $39.99
// On the first line, you will receive your current balance – a floating-point number in the range [0.00…5000.00].
// Until you receive the command "Game Time", you have to keep buying games. When a game is bought, the user's
// balance decreases by the price of the game.
// Additionally, the program should obey the following conditions:
// • If a game the user is trying to buy is not present in the table above, print "Not Found" and read the next
// line.
// • If at any point, the user has $0 left, print "Out of money!" and end the program.
// • Alternatively, if the user is trying to buy a game that they can't afford, print "Too Expensive" and read
// the next line.
// • If the game exists and the player has the money for it, print "Bought {nameOfGame}".
// When you receive "Game Time", print the user's remaining money and total spent on games, rounded to the 2
// nd
// decimal place.

using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal capital = decimal.Parse(Console.ReadLine());
            decimal totalPrice = 0m;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${totalPrice:f2}. Remaining: ${capital:f2}");
                    break;
                }
                else if (input == "OutFall 4")
                {
                    if (capital >= 39.99m)
                    {
                        capital -= 39.99m;
                        totalPrice += 39.99m;
                        Console.WriteLine("Bought OutFall 4");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    if (capital >= 39.99m)
                    {
                        capital -= 39.99m;
                        totalPrice += 39.99m;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "CS: OG")
                {
                    if (capital >= 15.99m)
                    {
                        capital -= 15.99m;
                        totalPrice += 15.99m;
                        Console.WriteLine("Bought CS: OG");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "Zplinter Zell")
                {
                    if (capital >= 19.99m)
                    {
                        capital -= 19.99m;
                        totalPrice += 19.99m;
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "Honored 2")
                {
                    if (capital >= 59.99m)
                    {
                        capital -= 59.99m;
                        totalPrice += 59.99m;
                        Console.WriteLine("Bought Honored 2");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "RoverWatch")
                {
                    if (capital >= 29.99m)
                    {
                        capital -= 29.99m;
                        totalPrice += 29.99m;
                        Console.WriteLine("Bought RoverWatch");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                if (capital == 0) { Console.WriteLine("Out of money!"); break; }
            }
        }
    }
}