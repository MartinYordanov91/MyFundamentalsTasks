// Write a program that accumulates coins. Until the "Start" command is given, you will receive coins, and only the
// valid ones should be accumulated. Valid coins are:
// • 0.1, 0.2, 0.5, 1 and 2
// If an invalid coin is inserted, print "Cannot accept {money}" and continue to the next line.
// On the next lines, until the "End" command is given, you will start receiving products, which a customer wants to
// buy. The vending machine has only:
// • "Nuts" with a price of 2.0
// • "Water" with a price of 0.7
// • "Crisps" with a price of 1.5
// • "Soda" with a price of 0.8
// • "Coke" with a price of 1.0
// If the customer tries to purchase a not existing product, print "Invalid product".
// When a customer has enough money to buy the selected product, print "Purchased {product name}",
// otherwise print "Sorry, not enough money" and continue to the next line.
// When the "End" command is given print the reminding balance, formatted to the second decimal point: "Change:
// {money left}". 

using System;


namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal ckesh = 0m;

            while (input != "Start")
            {
                decimal coin = decimal.Parse(input);

                if (coin == 0.1m)
                {
                    ckesh += 0.1m;
                }
                else if (coin == 0.2m)
                {
                    ckesh += 0.2m;
                }
                else if (coin == 0.5m)
                {
                    ckesh += 0.5m;
                }
                else if (coin == 1m)
                {
                    ckesh += 1m;
                }
                else if (coin == 2m)
                {
                    ckesh += 2m;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                
                if (input == "Nuts")
                {
                    if ( ckesh >= 2.0m)
                    {
                        ckesh -= 2m;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Water")
                {
                    if (ckesh >= 0.7m)
                    {
                        ckesh -= 0.7m;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if ( input == "Crisps")
                {
                    if (ckesh >= 1.5m)
                    {
                        ckesh -= 1.5m;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Soda")
                {
                    if (ckesh >= 0.8m)
                    {
                        ckesh -= 0.8m;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Coke")
                {
                    if (ckesh >= 1.0m)
                    {
                        ckesh -= 1.0m;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else { Console.WriteLine("Invalid product"); }

                input = Console.ReadLine();
            }

            if (input == "End") { Console.WriteLine($"Change: {ckesh:f2}"); }
        }
    }
}