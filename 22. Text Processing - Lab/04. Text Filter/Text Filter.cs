namespace _04._Text_Filter
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string textReperar = Console.ReadLine();

            for (int i = 0; i < bannWords.Length; i++)
            {
                textReperar = textReperar.Replace(bannWords[i], new string('*', bannWords[i].Length));
            }

            Console.WriteLine(textReperar);
        }
    }
}