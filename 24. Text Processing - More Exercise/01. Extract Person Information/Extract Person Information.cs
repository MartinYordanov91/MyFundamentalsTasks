namespace _01._Extract_Person_Information
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string textArg = Console.ReadLine();
                var sb = new StringBuilder();
                int index = textArg.IndexOf('@');
                index += 1;
                while (true)
                {
                    sb.Append(textArg[index]);
                    index += 1;
                    if (textArg[index] == '|')
                    {
                        break;
                    }
                }
                sb.Append(" is ");

                index = textArg.IndexOf('#');
                index += 1;
                while (true)
                {
                    sb.Append(textArg[index]);
                    index += 1;
                    if (textArg[index] == '*')
                    {
                        break;
                    }
                }
                sb.Append(" years old.");

                Console.WriteLine(sb);
            }
        }
    }
}