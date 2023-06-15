namespace _06._Replace_Repeating_Chars
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder();

            char curent = input[0];
            sb.Append(curent);

            for (int i = 1; i < input.Length; i++)
            {
                if (curent != input[i])
                {
                    curent = input[i];
                    sb.Append(curent);
                }
            }

            Console.WriteLine(sb);

        }
    }
}