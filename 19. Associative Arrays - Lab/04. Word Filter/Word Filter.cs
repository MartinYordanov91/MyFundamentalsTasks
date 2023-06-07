namespace _04._Word_Filter
{
    using System;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length % 2 == 0)
                .ToList()
                .ForEach(w =>
                {
                    Console.WriteLine(w);
                });

            
        }
    }
}