namespace _05._Dragon_Army
{
    using System;
    using System.Security.Cryptography.X509Certificates;
    using static System.Net.Mime.MediaTypeNames;

    internal class Program
    {
        static void Main(string[] args)
        {
            var dragons = new List<Dragon>();
            var colors = new Dictionary<string, int>();

            AddDragons(dragons, colors);
            PrintDragonsAndStats(dragons, colors);
            
        }

        public static void PrintDragonsAndStats(List<Dragon> dragons, Dictionary<string, int> colors)
        {
            foreach (var color in colors)
            {
                double avrgDMG = 0;
                double avrgHP = 0;
                double avrgAR = 0;
                foreach (var dragon in dragons)
                {
                    if (dragon.Color == color.Key)
                    {
                        avrgDMG += dragon.Damage;
                        avrgHP += dragon.Healt;
                        avrgAR += dragon.Armor;
                    }
                }

                Console.WriteLine($"{color.Key}::({(avrgDMG / color.Value):f2}/{(avrgHP / color.Value):f2}/{(avrgAR / color.Value):f2})");
                foreach (var dragon in dragons.OrderBy(n => n.Name))
                {
                    if (dragon.Color == color.Key)
                    {
                        Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Healt}, armor: {dragon.Armor}");
                    }
                }
            }
        }
        public static void AddDragons(List<Dragon> dragons , Dictionary<string ,int> colors)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] curentArg = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string color = curentArg[0];
                string name = curentArg[1];
                int damage = 45;
                int healt = 250;
                int armor = 10;
                if (curentArg[2] != "null") { damage = int.Parse(curentArg[2]); }
                if (curentArg[3] != "null") { healt = int.Parse(curentArg[3]); }
                if (curentArg[4] != "null") { armor = int.Parse(curentArg[4]); }

                if (dragons.Any(c => c.Color == color && c.Name == name) == false)
                {
                    Dragon dragon = new Dragon(color, name, damage, healt, armor);
                    dragons.Add(dragon);

                    if (colors.ContainsKey(color) == false)
                    {

                        colors.Add(color, 0);
                    }
                    colors[color]++;
                }
                else
                {
                    dragons.First(c => c.Color == color && c.Name == name).Damage = damage;
                    dragons.First(c => c.Color == color && c.Name == name).Healt = healt;
                    dragons.First(c => c.Color == color && c.Name == name).Armor = armor;
                }
            }
        }
    }


    public class Dragon
    {
        public Dragon(string color, string name, int damage, int healt, int armor)
        {
            Color = color;
            Name = name;
            Damage = damage;
            Healt = healt;
            Armor = armor;
        }
        public string Color { get; set; }

        public string Name { get; set; }

        public int Damage { get; set; }

        public int Healt { get; set; }

        public int Armor { get; set; }


    }
}

