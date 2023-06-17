namespace _02._Ascii_Sumator
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int num = 0;

            foreach (var item in text)
            {
                if (item > start && item < end)
                {
                    num += item;
                }
            }

            Console.WriteLine(num);
        }
    }
}