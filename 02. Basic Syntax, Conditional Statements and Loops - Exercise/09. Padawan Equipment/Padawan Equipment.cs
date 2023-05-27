// Yoda is starting his newly created Jedi academy. So, he asked master John to buy the needed equipment. The number
// of items depends on how many students will sign up. The equipment for each Padawan contains:
// • Lightsaber
// • Belt
// • Robe
// You will be given the amount of money John has, the number of students and the prices of each item. Calculate if
// John has enough money to buy equipment for each Padawan or how much more money he needs.
// There are some additional requirements:
// • Lightsabres sometimes break, so John should buy 10% more (taken from the students' count), rounded up
// to the next integer.
// • Every sixth belt is free.
// Input / Constraints
// The input data should be read from the console. It will consist of exactly 5 lines:
// • The amount of money John has – floating-point number in the range [0.00…1000.00].
// • The count of students – integer in the range [0…100].
// • The price of lightsabers for a single saber – floating-point number in the range [0.00…100.00].
// • The price of robes for a single robe – floating-point number in the range [0.00…100.00].
// • The price of belts for a single belt – floating-point number in the range [0.00…100.00].
// The input data will always be valid. There is no need to check it explicitly.
// Output
// The output should be printed on the console.
// • If the calculated price of the equipment is less or equal to the money John has:
// o "The money is enough - it would cost {the cost of the equipment}lv."
// • If the calculated price of the equipment is more than the money John has:
// o " John will need {neededMoney}lv more."
// • All prices must be rounded to two digits after the decimal point

using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            int numOfPeople = int.Parse(Console.ReadLine());
            decimal lightSabers = decimal.Parse(Console.ReadLine());
            decimal robes = decimal.Parse(Console.ReadLine());
            decimal belts = decimal.Parse(Console.ReadLine());

            double numLightSabers = 0;
            int discoundBelt = 0;
            decimal price = 0;

            numLightSabers = Math.Ceiling(1.1 * numOfPeople);
            discoundBelt = numOfPeople / 6;


            price = ((decimal)numLightSabers * lightSabers) + (robes * numOfPeople) + (belts * (numOfPeople - discoundBelt));

            if (price <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {price:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(price - amountOfMoney):f2}lv more.");
            }
        }
    }
}