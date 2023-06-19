namespace _03._Match_Dates
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\b(?<Day>\d{2})(\.|\/|-)(?<Month>[A-Z][a-z]{2})\1(?<Year>\d{4})\b";
            string input = Console.ReadLine();
            MatchCollection dates = Regex.Matches(input , patern);
            
            foreach (Match match in dates)
            {
                Console.WriteLine($"Day: {match.Groups["Day"]}, Month: {match.Groups["Month"]}, Year: {match.Groups["Year"]}");
            }
        }
    }
}