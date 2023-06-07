namespace _01._Count_Chars_in_a_String
{
    using System;
    using System.Linq;
    internal class Program
    {
        static void Main()
        {
            var textDictionary = new Dictionary<char, int>();
            FillingDictionary(textDictionary);
            PrintDictionary(textDictionary);
        }
        public static void PrintDictionary(Dictionary<char, int> textDictionary)
        {
            foreach (var c in textDictionary)
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }
        public static void FillingDictionary(Dictionary<char, int> textDictionary)
        {
            char[] chars = Console.ReadLine().ToCharArray();

            foreach (char c in chars)
            {
                if (c != ' ')
                {
                    if (textDictionary.ContainsKey(c) == false)
                    {
                        textDictionary.Add(c, 0);
                    }
                    textDictionary[c]++;

                }
            }
        }
    }
}