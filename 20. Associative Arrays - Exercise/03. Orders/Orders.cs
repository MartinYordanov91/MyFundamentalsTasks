namespace _3._Orders
{
    using System;
    using System.Security.Cryptography.X509Certificates;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>();
            FillAllOrders(products);
            PrintAllOrders(products);
        }
        public static void PrintAllOrders(List<Products> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
        public static void FillAllOrders ( List<Products> products)
        {
            string comandArg;
            while ((comandArg = Console.ReadLine()) != "buy")
            {
                string[] productArg = comandArg
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = productArg[0];
                decimal price = decimal.Parse(productArg[1]);
                int quantity = int.Parse(productArg[2]);

                if (products.Any(x => x.Name == name))
                {
                    products.First(x => x.Name == name).Price = price;
                    products.First(x => x.Name == name).Quantity += quantity;

                }
                else
                {
                    Products product = new Products(name, price, quantity);
                    products.Add(product);
                }

            }
        }
    }
    public class Products
    {
        public Products(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Name} -> {(Price * Quantity):f2}";
        }
    }
}