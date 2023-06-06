namespace _03._Word_Synonyms
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            var wordSynonymsC = new Dictionary<string, List<string>>();

            FillDictionary(wordSynonymsC);
            PrintDictionary(wordSynonymsC);
        }

        public static void PrintDictionary(Dictionary<string, List<string>> wordSynonymsC)
        {
            foreach (var word in wordSynonymsC)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }

        public static void FillDictionary(Dictionary<string, List<string>> wordSynonymsC)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (wordSynonymsC.ContainsKey(word))
                {
                    wordSynonymsC[word].Add(synonym);
                }
                else
                {
                    wordSynonymsC.Add(word, new List<string>() { synonym });
                }
            }
        }
    }
}