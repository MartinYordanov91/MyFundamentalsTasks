namespace _03._SoftUni_Bar_Income
{

    using System;
    using System.Runtime.Serialization;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            Regex barIncomeFilter = new Regex(@"%(?<customer>[A-Z][a-z]+)%[^|%$.]*<(?<product>\w+)>[^|%$.]*\|(?<count>\d+)\|[^|%$.]*?(?<price>\d+\.?\d+)\$");
            decimal sum = 0m;

            string curentInput = string.Empty;

            while ((curentInput = Console.ReadLine())!= "end of shift")
            {
                Match match = barIncomeFilter.Match(curentInput);
                if (match.Success)
                {
                    string name = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);

                    Console.WriteLine($"{name}: {product} - {(price*count):f2}");
                    sum += price * count;
                }
            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}