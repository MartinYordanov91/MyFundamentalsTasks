namespace _05._HTML
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<h1>");
            sb.AppendLine($"    {Console.ReadLine()}");
            sb.AppendLine("</h1>");
            sb.AppendLine("<article>");
            sb.AppendLine($"    {Console.ReadLine()}");
            sb.AppendLine("</article>");

            string end = string.Empty;
            while ((end = Console.ReadLine())!= "end of comments")
            {
                sb.AppendLine("<div>");
                sb.AppendLine($"    {end}");
                sb.AppendLine("</div>");
            }

            Console.WriteLine(sb);
        }
    }
}