// You will receive a number that represents how many lines we will get as input. On the next N lines, you will receive a
// string with 2 numbers, separated by a single space. You need to compare them. If the left number is greater than
// the right number, you need to print the sum of all digits in the left number, otherwise, print the sum of all digits in
// the right number.

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < n; i++)
            {
                long[] arry =Console.ReadLine()
                    .Split()
                    .Select(long.Parse)
                    .ToArray();

                long sum = 0;

                if (arry[0] > arry[1])
                {
                    string num = arry[0].ToString();
                    int position = num[0] == '-' ? 1 : 0;

                    for (int f  = position; f < num.Length; f++)
                    {
                        sum += int.Parse(num[f].ToString());
                        
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    string num = arry[1].ToString();
                    int position = num[0] == '-' ? 1 : 0;

                    for (int s = position; s < num.Length; s++)
                    {
                        sum += int.Parse(num[s].ToString());
                        
                    }
                    Console.WriteLine(sum);
                }  
            }
        }
    }
}