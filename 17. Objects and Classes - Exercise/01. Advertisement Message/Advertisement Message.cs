// Create a program that generates random fake advertisement messages to advertise a product. The messages must
// consist of 4 parts: phrase + event + author + city. Use the following predefined parts:
// • Phrases – {"Excellent product.", "Such a great product.", "I always use that
// product.", "Best product of its category.", "Exceptional product.", "I can't
// live without this product."}
// • Events – {"Now I feel good.", "I have succeeded with this product.", "Makes
// miracles. I am happy of the results!", "I cannot believe but now I feel
// awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}
// • Authors – {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}
// • Cities – {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}
// The format of the output message is the following: "{phrase} {event} {author} – {city}."
// You will receive the number of messages to be generated. Print each random message at a separate line.

namespace _01._Advertisement_Message
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };

            List<string> events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            List<string> authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            List<string> cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();

            int fakeAdverttisement = int.Parse(Console.ReadLine());

            for (int i = 0; i < fakeAdverttisement; i++)
            {
                int indexP = random.Next(phrases.Count);
                int indexE = random.Next(events.Count);
                int indexA = random.Next(authors.Count);
                int indexC = random.Next(cities.Count);

                Console.WriteLine($"{phrases[indexP]} {events[indexE]} {authors[indexA]} – {cities[indexC]}.");
                
            }
        }
    }
}


