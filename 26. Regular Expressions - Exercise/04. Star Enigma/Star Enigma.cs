namespace _04._Star_Enigma
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main()
        {
            Regex regexForNumMatches = new Regex(@"[sSaAtTrR]");
            int cryptedMasageCount = int.Parse(Console.ReadLine());
            string curentMasage = string.Empty;
            var attacked = new SortedDictionary<string, string>();
            var destroyed = new SortedDictionary<string, string>();

            for (int i = 0; i < cryptedMasageCount; i++)
            {
                curentMasage = Console.ReadLine();
                MatchCollection regexMatches = regexForNumMatches.Matches(curentMasage);
                int matchesNum = regexMatches.Count;
                var sb = new StringBuilder();

                char[] chars = curentMasage.ToCharArray();

                foreach (var c in chars)
                {
                    int cChar = c - matchesNum;
                    sb.Append((char)cChar);
                }
                Regex information = new Regex(@"@(?<name>[A-Za-z]+)[^@\-!:>]*?:\d+[^@\-!:>]*?!(?<type>[A|D])![^@\-!:>]*?->\d+");
                Match match = information.Match(sb.ToString());

                if (match.Success)
                {
                    if (match.Groups["type"].Value == "A")
                    {
                        attacked.Add(match.Groups["name"].Value , match.Groups["type"].Value);
                    }
                    else
                    {
                        destroyed.Add(match.Groups["name"].Value , match.Groups["type"].Value);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (var att in attacked)
            {
                Console.WriteLine($"-> {att.Key}");
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (var dess in destroyed)
            {
                Console.WriteLine($"-> {dess.Key}");
            }


        }
    }
}