namespace _06._Extract_Emails
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            var emailsReg = new Regex(@" (?<user>(?:[A-Za-z0-9]+)[._-]?[A-Za-z0-9]+)@(?<host>(?:[A-Za-z0-9]+(\.|-))*[A-Za-z0-9]+\.[A-Za-z]+)");
            var text = Console.ReadLine();
            var matchColection = emailsReg.Matches(text);

            foreach (Match match in matchColection)
            {
                Console.WriteLine(match.Value.Trim());
            }

        }
    }
}