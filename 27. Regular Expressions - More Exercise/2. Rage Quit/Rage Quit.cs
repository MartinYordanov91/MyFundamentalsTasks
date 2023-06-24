namespace _2._Rage_Quit
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            var synbol = new Regex(@"[!-\/:-~ ]+");
            var multiplicate = new Regex(@"\d+");
            var unique = new List<char>();
            var inputArg = Console.ReadLine().Trim();
            var synbolColection= synbol.Matches(inputArg);
            var multiplicateColection= multiplicate.Matches(inputArg);
            var sb = new StringBuilder();

            for (int i = 0; i < synbolColection.Count; i++)
            {
                char[] synbols = synbolColection[i].Value.ToUpper().ToCharArray();
                int num = int.Parse(multiplicateColection[i].Value);

                for (int m = num-1; m >= 0; m--)
                {
                    foreach (var item in synbols)
                    {
                        if(unique.Contains(item) == false)
                        {
                            unique.Add(item);
                        }

                        sb.Append(item);
                    }
                }
            }

            Console.WriteLine($"Unique symbols used: {unique.Count}");
            Console.WriteLine(sb);

        }
    }
}