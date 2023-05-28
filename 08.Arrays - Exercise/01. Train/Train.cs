// A train has n number of wagons (integer, received as input). On the next n lines, you will receive the number of
// people that are going to get on each wagon. Print out the number of passengers in each wagon followed by the
// total number of passengers on the train.

using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nNum = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] trainArry = new int[nNum];

            for (int i = 0; i < nNum; i++)
            {
                int inputNumOfPeople = int.Parse(Console.ReadLine());

                trainArry[i] = inputNumOfPeople;
                sum += inputNumOfPeople;
            }
            Console.WriteLine(string.Join(" " , trainArry)); 
            Console.WriteLine(sum);
        }
    }
}