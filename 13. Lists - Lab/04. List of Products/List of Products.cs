// Read a number n and n lines of products. Print a numbered list of all the products ordered by name

using System;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<string> products= new List<string>();

            for (int i = 0; i < length; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();

            for (int n = 0; n < length; n++)
            {
                Console.WriteLine("{0}.{1}",n +1 , products[n]);
            }
        }
    }
}