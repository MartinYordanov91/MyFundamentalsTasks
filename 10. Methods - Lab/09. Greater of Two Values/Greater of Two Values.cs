// You are given an input of two values of the same type. The values can be of type int, char or string. Create
// methods called GetMax(), which can compare int, char or string and returns the biggest of the two values.


using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                IntGreater();
            }
            else if (input == "char")
            {
                CharGreater();
            }
            else if (input == "string")
            {
                StringGreater();
            }
        }

        static void StringGreater()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if(string.Compare(a ,b) == 1) { Console.WriteLine(a); }
            else { Console.WriteLine(b); }
        }

        static void CharGreater()
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            if ((int)a > (int)b) { Console.WriteLine(a); }
            else { Console.WriteLine(b); }
        }

        static void IntGreater()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a > b) { Console.WriteLine(a); }
            else { Console.WriteLine(b); }
        }
    }
}