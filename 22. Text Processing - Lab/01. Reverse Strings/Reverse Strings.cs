namespace _01._Reverse_Strings
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine())!= "end")
            {
                char[] revers = input.Reverse().ToArray();

                Console.WriteLine($"{input} = {string.Join("" , revers)}");
            }
        }
    }
}