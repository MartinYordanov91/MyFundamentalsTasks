// You will receive three lines from the console:
// • A count of people who are going on vacation.
// • Type of the group (Students, Business or Regular).
// • The day of the week which the group will stay on (Friday, Saturday or Sunday).
// Based on the given information calculate how much the group will pay for the entire vacation.
// The price for a single person is as follows:
//            Friday      Saturday        Sunday
// Students    8.45       9.80            10.46
// Business    10.90      15.60            16
// Regular      15          20            22.50
// There are also discounts based on some conditions:
// • For Students – if the group is 30 or more people, you should reduce the total price by 15%.
// • For Business – if the group is 100 or more people, 10 of the people stay for free.
// • For Regular – if the group is between 10 and 20 people (both inclusively), reduce the total price by 5%.
// Note: You should reduce the prices in that EXACT order!
// As an output print the final price which the group is going to pay in the format:
// "Total price: {price}"
// The price should be formatted to the second decimal point.

using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int People = int.Parse(Console.ReadLine()!);
            string groupType = Console.ReadLine()!;
            string dayOfTheWeek = Console.ReadLine()!;

            decimal price = 0.0m;

            if (groupType == "Students")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 8.45m * People;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 9.80m * People;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 10.46m * People;
                }
                if (People >= 30)
                {
                    price *= 0.85m;
                }
            }
            else if (groupType == "Business")
            {
                if (dayOfTheWeek == "Friday")
                {
                    if (People >= 100)
                    {
                        People -= 10;
                        price = 10.90m * People;
                    }
                    else
                    {
                        price = 10.90m * People;
                    }
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    if (People >= 100)
                    {
                        People -= 10;
                        price = 15.60m * People;
                    }
                    else
                    {
                        price = 15.60m * People;
                    }
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    if (People >= 100)
                    {
                        People -= 10;
                        price = 16.00m * People;
                    }
                    else
                    {
                        price = 16.00m * People;
                    }
                }

            }
            else if (groupType == "Regular")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 15.00m * People;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 20.00m * People;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 22.50m * People;
                }
                if (People >= 10 && People <= 20)
                {
                    price *= 0.95m;
                }
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}