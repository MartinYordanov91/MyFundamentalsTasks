namespace _08._Letters_Change_Numbers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            double result = 0;
            double output = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                char firstSym = inputs[i].First();
                char lastSym = inputs[i].Last();
                int number = int.Parse(inputs[i].Substring(1, inputs[i].Length - 2));

                if (firstSym >= 'A' && firstSym <= 'Z')
                {
                    double position = firstSym - 'A' + 1;
                    result = number / position;
                }
                else
                {
                    double position = firstSym - 'a' + 1;
                    result = number * position;
                }

                if (lastSym >= 'A' && lastSym <= 'Z')
                {
                    double position = lastSym - 'A' + 1;
                    result -= position;
                }
                else
                {
                    double position = lastSym - 'a' + 1;
                    result += position;
                }
                output+= result;
            }
            Console.WriteLine($"{output:f2}");
        }
    }
}