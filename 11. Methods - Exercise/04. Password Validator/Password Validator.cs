// Create a program that checks if a given password is valid.
// The password validation rules are:
// • It should contain 6 – 10 characters (inclusive)
// • It should contain only letters and digits
// • It should contain at least 2 digits
// If it is not valid, for any unfulfilled rule print the corresponding message:
// • "Password must be between 6 and 10 characters"
// • "Password must consist only of letters and digits"
// • "Password must have at least 2 digits"


using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool amountOfSynvoles = false;
            bool digitsAndLetters = false;
            bool countDigitis = false;

            amountOfSynvoles = SynvolAmount(input, amountOfSynvoles);
            digitsAndLetters = AreDigitsOrLetters(input, digitsAndLetters);
            countDigitis = AreDigitsTwoOrMore(input, countDigitis);

            if (amountOfSynvoles && digitsAndLetters && countDigitis)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool AreDigitsTwoOrMore(string input, bool countDigitis)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 47 && input[i] < 58)
                {
                    count++;
                }
            }
            if (count > 1) { countDigitis = true; }
            else { Console.WriteLine("Password must have at least 2 digits"); }

            return countDigitis;
        }

        static bool AreDigitsOrLetters(string input, bool digitsAndLetters)
        {
            
            if (input.All(char.IsLetterOrDigit))
            {
                digitsAndLetters = true;
            }
            else
            {
                Console.WriteLine("Password must consist only of letters and digits");
                
            }

            return digitsAndLetters;
        }

        static bool SynvolAmount(string input, bool amountOfSynvoles)
        {
            if (input.Length > 5 && input.Length < 11)
            {
                amountOfSynvoles = true;
            }
            if (!amountOfSynvoles)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            return amountOfSynvoles;
        }
       
    }
}