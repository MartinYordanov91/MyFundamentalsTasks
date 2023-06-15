namespace _07._String_Explosion
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder();
            int explose = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    explose += input[i + 1] - '0';
                    sb.Append(input[i]);
                }
                else if (explose > 0)
                {
                    explose-= 1;
                }
                else
                {
                    sb.Append(input[i]);
                }
            }
            Console.WriteLine(sb);
        }
    }
}