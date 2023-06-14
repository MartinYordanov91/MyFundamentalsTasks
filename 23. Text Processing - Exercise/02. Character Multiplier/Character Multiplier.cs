namespace _02._Character_Multiplier
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int sum = Multiplechars(input[0], input[1]);
            Console.WriteLine(sum);
        }

        private static int Multiplechars(string first, string second )
        {
            int minLenght = Math.Min(first.Length, second.Length);
            int sums = 0; 

            for (int i = 0; i < minLenght; i++)
            {
                sums += first[i] * second[i];
            }

            if(minLenght < first.Length)
            {
                for (int n = minLenght; n < first.Length; n++)
                {
                    sums += first[n];
                }
            }
            else if (minLenght < second.Length)
            {
                for (int n = minLenght; n < second.Length; n++)
                {
                    sums += second[n];
                }
            }

           return sums;
        }
    }
}