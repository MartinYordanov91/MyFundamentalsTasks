// Create a method that receives two parameters:
// • A string
// • A number n (integer) represents how many times the string will be repeated
// The method should return a new string, containing the initial one, repeated n times without space. 

using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main()
        {
            string someText = Console.ReadLine();
            int timeRepeated = int.Parse(Console.ReadLine());
            string outSomeText = "";
            outSomeText = RepeatedText(someText, timeRepeated, outSomeText);
            Console.WriteLine(outSomeText);
        }

        static string RepeatedText(string someText, int timeRepeated, string outSomeText)
        {
            for (int i = 0; i < timeRepeated; i++)
            {
                outSomeText += someText;
            }

            return outSomeText;
        }
    }
}