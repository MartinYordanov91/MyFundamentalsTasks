namespace _02._Repeat_Strings
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine()
                .Split(" " , StringSplitOptions.RemoveEmptyEntries);

            string result = string.Empty;

            for (int i = 0; i < inputString.Length; i++)
            {
                for (int n = 0; n < inputString[i].Length; n++)
                {
                    result += inputString[i];
                }
            }

            Console.WriteLine($"{result}");
        }
    }
}