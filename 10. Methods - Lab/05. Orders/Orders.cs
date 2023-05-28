// Create a program that calculates and prints the total price of an order. The method should receive two parameters:
// • A string, representing a product - "coffee", "water", "coke", "snacks"
// • An integer, representing the quantity of the product
// The prices for a single item of each product are:
// • coffee – 1.50
// • water – 1.00
// • coke – 1.40
// • snacks – 2.00
// Print the result, rounded to the second decimal place

using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;

            switch (item)
            {
                case "coffee":
                    price = coffee(quantity);
                    break;
                case "water":
                    price = water(quantity);
                    break;
                case "coke":
                    price = coke(quantity);
                    break;
                case "snacks":
                    price = snacks(quantity);
                    break;
            }
            Console.WriteLine($"{price:f2}");
        }

        static double snacks(int quantity)
        {
            return quantity * 2.00;
        }

        static double coke(int quantity)
        {
            return quantity * 1.40;
        }

        static double water(int quantity)
        {
            return quantity * 1.0;
        }

        static double coffee(int quantity)
        {
            return quantity * 1.5;
        }
    }
}