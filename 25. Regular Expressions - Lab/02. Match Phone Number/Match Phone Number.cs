namespace _02._Match_Phone_Number
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359(\s|-)2\1\d{3}\1\d{4}\b";
            string text = Console.ReadLine();
            MatchCollection matches = Regex.Matches(text, regex);
            Console.WriteLine(string.Join(", " , matches));
        }
    }
}