namespace _03._Substring
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string remuveWords = Console.ReadLine();
            string words = Console.ReadLine();
            int rWordIndex = 0;

            while (words.Contains(remuveWords))
            {
                rWordIndex = words.IndexOf(remuveWords);

                words = words.Remove(rWordIndex, remuveWords.Length);
            }
            
            Console.WriteLine($"{words}");
        }
    }
}