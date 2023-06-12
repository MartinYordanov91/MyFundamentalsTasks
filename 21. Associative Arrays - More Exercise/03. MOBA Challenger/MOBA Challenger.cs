namespace _03._MOBA_Challenger
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            var pLayers = new Dictionary<string, Dictionary<string, int>>();

            AddOrFight(pLayers);
            PrintOutput(pLayers);
        }
        public static void PrintOutput(Dictionary<string, Dictionary<string, int>> pLayers)
        {
            foreach (var player in pLayers
                .OrderByDescending(c => c.Value.Values.Sum())
                .ThenBy(c => c.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var item in player.Value.OrderByDescending(p => p.Value).ThenBy(c => c.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
            }
        }
        public static void AddOrFight(Dictionary<string, Dictionary<string, int>> pLayers)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains("->"))
                {
                    AddPlayrs(pLayers, input);
                }
                else if (input.Contains("vs"))
                {
                    PlayrsFight(pLayers, input);

                }
            }
        }
        public static void AddPlayrs(Dictionary<string, Dictionary<string, int>> pLayers, string input)
        {
            string[] comandArg = input
                        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
            string name = comandArg[0];
            string position = comandArg[1];
            int power = int.Parse(comandArg[2]);

            if (pLayers.ContainsKey(name) == false)
            {
                pLayers.Add(name, new Dictionary<string, int>());
                pLayers[name].Add(position, power);
            }
            else
            {
                if (pLayers[name].ContainsKey(position) == false)
                {
                    pLayers[name].Add(position, power);
                }
                else
                {
                    if (pLayers[name][position] < power)
                    {
                        pLayers[name][position] = power;
                    }
                }
            }
        }
        public static void PlayrsFight(Dictionary<string, Dictionary<string, int>> pLayers, string input)
        {

            string[] comandArg = input
                .Split(" vs ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string userRed = comandArg[0];
            string userGreen = comandArg[1];


            if (pLayers.ContainsKey(userRed) == false && pLayers.ContainsKey(userGreen) == false)
            {
                return;
            }

            else if (IsCoincidenceSamePosition(pLayers, input))
            {
                string position = PositionDiscription(pLayers, input);

                if (pLayers[userGreen][position] > pLayers[userRed][position])
                {
                    pLayers.Remove(userRed);

                }
                else if (pLayers[userGreen][position] < pLayers[userRed][position])
                {
                    pLayers.Remove(userGreen);
                }
            }
        }

        static string PositionDiscription(Dictionary<string, Dictionary<string, int>> pLayers, string input)
        {
            string[] comandArg = input
                       .Split(" vs ", StringSplitOptions.RemoveEmptyEntries)
                       .ToArray();

            string userRed = comandArg[0];
            string userGreen = comandArg[1];

            string curentPosition = string.Empty;

            foreach (var item in pLayers[userGreen])
            {
                foreach (var item2 in pLayers[userRed])
                {
                    if (item.Key == item2.Key)
                    {
                        curentPosition = item.Key;
                    }
                }

            }
            return curentPosition;
        }

        static bool IsCoincidenceSamePosition(Dictionary<string, Dictionary<string, int>> pLayers, string input)
        {
            string[] comandArg = input
                       .Split(" vs ", StringSplitOptions.RemoveEmptyEntries)
                       .ToArray();

            string userRed = comandArg[0];
            string userGreen = comandArg[1];

            bool isCoincidence = false;

            foreach (var item in pLayers[userGreen])
            {
                foreach (var item2 in pLayers[userRed])
                {
                    if (item.Key == item2.Key)
                    {
                        isCoincidence = true;
                    }
                }

            }
            return isCoincidence;
        }
    }
}