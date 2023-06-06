namespace _01._Count_Real_Numbers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new SortedDictionary<double, int>();

            FillDictionary(numbers);
            PrintResult(numbers);

        }

        public static void PrintResult(SortedDictionary<double, int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }

        public static void FillDictionary(SortedDictionary<double, int> numbers)
        {
            double[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            foreach (var num in nums)
            {
                if (numbers.ContainsKey(num))
                {
                    numbers[num]++;
                }
                else
                {
                    numbers.Add(num, 1);
                }
            }
        }
    }
}