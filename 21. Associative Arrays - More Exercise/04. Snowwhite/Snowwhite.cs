namespace _04._Snowwhite
{
    using System;
    using System.Drawing;

    internal class Program
    {
        static void Main(string[] args)
        {
            var dwarfs = new List<Dwarf>();
            var hat = new Dictionary<string, int>();

            AddDwarfsAndHats(hat, dwarfs);
            PrintOutput(hat, dwarfs);
        }
        public static void PrintOutput(Dictionary<string, int> hat, List<Dwarf> dwarfs)
        {
            foreach (Dwarf dwarf in dwarfs.OrderByDescending(x => x.Strong)
                .ThenByDescending(x => hat[x.Color]))
            {
                Console.WriteLine(dwarf);
            }
        }

        public static void AddDwarfsAndHats(Dictionary<string, int> hat, List<Dwarf> dwarfs)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] comandArg = input
                    .Split(" <:> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = comandArg[0];
                string color = comandArg[1];
                int strong = int.Parse(comandArg[2]);

                if (dwarfs.Any(n => n.Name == name && n.Color == color))
                {
                    if (dwarfs.First(n => n.Name == name && n.Color == color).Strong < strong)
                    {
                        dwarfs.First(n => n.Name == name && n.Color == color).Strong = strong;
                    }
                    continue;
                }
                else
                {
                    var dwarf = new Dwarf(name, color, strong);
                    dwarfs.Add(dwarf);

                    if (hat.ContainsKey(color) == false)
                    {
                        hat.Add(color, 0);
                    }
                    hat[color]++;
                }


            }
        }
    }

    public class Dwarf
    {
        public Dictionary<string, int> colorCount = new Dictionary<string, int>();
        public Dwarf(string name, string color, int strong)
        {
            Name = name;
            Color = color;
            Strong = strong;

            colorCount = new Dictionary<string, int>();
        }

        public string Name { get; set; }

        public string Color { get; set; }

        public int Strong { get; set; }



        public override string ToString()
        {
            return $"({Color}) {Name} <-> {Strong}";
        }

    }
}
