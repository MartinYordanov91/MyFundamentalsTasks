namespace _05._Digits__Letters_and_Other
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToArray();

            var sb = new StringBuilder();

            sb.AppendLine(string.Join("", input.Where(x => char.IsDigit(x))));
            sb.AppendLine(string.Join("", input.Where(x => char.IsLetter(x))));
            sb.AppendLine(string.Join("", input.Where(x => !char.IsLetterOrDigit(x))));

            Console.WriteLine(sb);
        }
    }
}