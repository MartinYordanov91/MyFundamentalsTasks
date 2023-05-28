// Create a program that keeps track of the guests that are going to a house party. On the first line, of input you are
// going to receive the number of commands that will follow.
// On the next lines, you are going to receive some of the following: "{name} is going!"
// • You have to add the person, if they are not on the guestlist already.
// • If the person is on the list print the following to the console: "{name} is already in the list!"
// "{name} is not going!"
// • You have to remove the person, if they are on the list.
// • If not, print out: "{name} is not in the list!"
// Finally, print all of the guests, each on a new line.


using System;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            List<string> listGuests = new List<string>();

            for (int i = 0; i < guests; i++)
            {
                string[] person = Console.ReadLine().Split().ToArray();

                if (person.Length < 4)
                {
                    if (listGuests.Contains(person[0]))
                    {
                        Console.WriteLine($"{person[0]} is already in the list!");
                    }
                    else
                    {
                        listGuests.Add(person[0]);
                    }
                }
                else
                {
                    if (listGuests.Contains(person[0]))
                    {
                        listGuests.Remove(person[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{person[0]} is not in the list!");
                    }
                }
            }

            for (int m = 0; m < listGuests.Count; m++)
            {
                Console.WriteLine(listGuests[m]);
            }

        }
    }
}