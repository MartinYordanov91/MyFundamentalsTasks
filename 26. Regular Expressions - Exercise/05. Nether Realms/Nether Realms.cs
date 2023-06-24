namespace _05._Nether_Realms
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            var demons = new List<Demons>();
            var letters = new Regex(@"[!-):-~]");
            var digits = new Regex(@"(?:-|\+)*?\d+(?:\.\d+)?");
            var multiplyingOrDividing = new Regex(@"\*|\/");
            var inputArg = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputArg.Length; i++)
            {
                var demonName = inputArg[i].Trim();

                if (demonName.Contains(' ') || demonName.Contains(','))
                {
                    continue;
                }

                int healt = 0;
                double damage = 0;

                MatchCollection leatterColections = letters.Matches(demonName);
                MatchCollection digitColections = digits.Matches(demonName);
                MatchCollection modColections = multiplyingOrDividing.Matches(demonName);

                foreach (Match leter in leatterColections)
                {
                    char n = char.Parse(leter.Value);
                    healt += n;
                }

                foreach (Match dig in digitColections)
                {
                    damage += double.Parse(dig.Value);
                }

                foreach (Match item in modColections)
                {

                    damage = item.Value == "*" ? damage *= 2 : damage /= 2;
                }

                Demons demon = new Demons(demonName, healt, damage);
                demons.Add(demon);
            }

            foreach (var dem in demons.OrderBy(n => n.Name))
            {
                Console.WriteLine(dem);
            }
        }
    }
    public class Demons
    {
        public Demons(string name, int healt, double damage)
        {
            Name = name;
            Health = healt;
            Damage = damage;
        }

        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Health} health, {Damage:f2} damage";
        }
    }
}