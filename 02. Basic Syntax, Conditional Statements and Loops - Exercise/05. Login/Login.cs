// On the first line, you will be given a username and your task is to try to log in the user. The user's password is the
// username reversed. On the next lines, you will receive passwords:
// • If the password is incorrect, print "Incorrect password. Try again.".
// • If the password is correct, print "User {username} logged in." and stop the program.
// Keep in mind that if the password is still incorrect on the fourth attempt, you should print: "User {username}
// blocked!".
// Then the program stops.

using System;

namespace _05._Login
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            char[] cArray = userName.ToCharArray();
            string paslort = "";
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                paslort += cArray[i];
            }

            bool on = false;

            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();
                if (input == paslort)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    on = true;
                    break;
                }
                if (i < 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

            }
            if(!on)
            {
                Console.WriteLine($"User {userName} blocked!");
            }
        }
    }
}