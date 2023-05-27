// You will receive input until you receive "END". Find what data type is the input. Possible data types are:
// • Integer
// • Floating point
// • Characters
// • Boolean
// • Strings
// Print the result in the following format: "{input} is {data type} type"

using System;

namespace _01._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int intType;
            double floatType;
            char charType;
            bool boolType;
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                if (int.TryParse(input, out intType)) Console.WriteLine($"{input} is integer type");
                else if (double.TryParse(input, out floatType)) Console.WriteLine($"{input} is floating point type");
                else if (bool.TryParse(input, out boolType)) Console.WriteLine($"{input} is boolean type");
                else if (char.TryParse(input, out charType)) Console.WriteLine($"{input} is character type");
                else Console.WriteLine($"{input} is string type");

            }
        }
    }
}