namespace _01._Furniture
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^>>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantyti>\d+).*?$");

            List<string> furnitures = new List<string>();
            decimal sum = 0m;
            string textInput = string.Empty;
            StringBuilder end = new StringBuilder();
            end.AppendLine("Bought furniture:");

            while ((textInput = Console.ReadLine()) != "Purchase")
            {
                Match furniture = regex.Match(textInput);

                if (furniture.Success)
                {
                    string name = furniture.Groups["name"].Value;
                    decimal price = decimal.Parse(furniture.Groups["price"].Value);
                    int quantyti = int.Parse(furniture.Groups["quantyti"].Value);

                    furnitures.Add(name);
                    sum += price * quantyti;
                }
            }

            foreach (var item in furnitures)
            {
                end.AppendLine(item);
            }

            end.Append("Total money spend: ");
            end.Append($"{sum:f2}");

            Console.WriteLine(end);
        }
    }
}