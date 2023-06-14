namespace _01._Valid_Usernames
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            foreach (var user in users)
            {
                if (IsValid(user))
                {
                    Console.WriteLine(user);
                }
            }
        }

        private static bool IsValid(string user)
        {

            if (IsValidLenght(user) && IsCOrectCharacters(user))
            {
                return true;
            }

            return false;
        }

        private static bool IsCOrectCharacters(string user)
        {

            if (user.All(cc => char.IsLetterOrDigit(cc) || cc == '_' || cc == '-'))
            {
                return true;
            }
            return false;
        }

        private static bool IsValidLenght(string user)
        {
            if (user.Length >= 3 && user.Length <= 16)
            {
                return true;
            }
            return false;
        }
    }
}