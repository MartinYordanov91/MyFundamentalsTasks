namespace _4._Santa_s_Secret_Helper
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {

            int key = int.Parse(Console.ReadLine());
            var nameBehavior = new Regex(@"@(?<name>[A-Za-z]+)[^@\-!:>]*!(?<behavior>G|N)!");
            string inputArg = string.Empty;
            var output = new StringBuilder();

            while ((inputArg = Console.ReadLine()) != "end")
            {
                var sb = new StringBuilder();
                foreach (var c in inputArg)
                {
                    sb.Append((char)(c - key));
                }

                Match match = nameBehavior.Match(sb.ToString());

                if (match.Groups["name"].Success && match.Groups["behavior"].Success)
                {
                    if (match.Groups["behavior"].Value == "G")
                    {
                        output.AppendLine(match.Groups["name"].Value);
                    }
                }
            }
            Console.WriteLine(output.ToString());
        }
    }
}