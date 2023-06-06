namespace _02._Odd_Occurrences
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            var colections = new Dictionary<string, int>();

            FillDictionary(colections);
            PrintDictionary(colections);
           
        }
        public static void PrintDictionary(Dictionary<string, int> colections)
        {
            // Func<int, bool> isOdd = x => x % 2 != 0;

            foreach (var item in colections)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }

        public static void FillDictionary(Dictionary<string , int> colections)
        {
            string[] stringInput = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

            foreach (var item in stringInput)
            {
                string toWowerItem = item.ToLower();

                if (colections.ContainsKey(toWowerItem))
                {
                    colections[toWowerItem]++;
                }
                else
                {
                    colections.Add(toWowerItem, 1);
                }

            }
        }
    }
}