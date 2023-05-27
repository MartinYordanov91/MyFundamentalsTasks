// Create a method that returns the English spelling of the last digit of a given number. Write a program that reads an
// integer and prints the returned value from this method.

using System;

namespace _02._English_Name_of_the_Last_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            LastDigit(number);
        }

        static void LastDigit(int number)
        {
            int lastDigit = number % 10;

            if (lastDigit == 0) { Console.WriteLine("zero"); }
            else if (lastDigit == 1) { Console.WriteLine("one"); }
            else if (lastDigit == 2) { Console.WriteLine("two"); }
            else if (lastDigit == 3) { Console.WriteLine("three"); }
            else if (lastDigit == 4) { Console.WriteLine("four"); }
            else if (lastDigit == 5) { Console.WriteLine("five"); }
            else if (lastDigit == 6) { Console.WriteLine("six"); }
            else if (lastDigit == 7) { Console.WriteLine("seven"); }
            else if (lastDigit == 8) { Console.WriteLine("eight"); }
            else if (lastDigit == 9) { Console.WriteLine("nine"); }
        }
    }
}