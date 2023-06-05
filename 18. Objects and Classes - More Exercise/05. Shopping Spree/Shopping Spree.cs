// Create two classes: class Person and class Product. Each person should have a name, money and a bag of
// products. Each product should have a name and a cost.
// Create a program, in which each command corresponds to a person buying a product. If the person can afford a
// product, add it to his bag. If a person doesn't have enough money, print an appropriate message: "{Person} can't
// afford {Product}".
// On the first two lines, you are given all people and all products. After all purchases, print every person in the order
// of appearance and all products that they have bought, also in order of appearance. If nothing was bought, print the
// name of the person followed by "Nothing bought".


namespace _05._Shopping_Spree
{
    using System;
    internal class Program
    {
        static void Main()
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            FillingPerson(persons);
            FillingProduct(products);

            string curentArg;

            while ((curentArg = Console.ReadLine()) != "END")
            {
                string[] curentCouple = curentArg
                    .Split(" " , StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = curentCouple[0];
                string item = curentCouple[1];
            }

        }

        public static void FillingProduct(List<Product> products)
        {
            string[] productInt = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < productInt.Length; i++)
            {
                string[] curentProduct = Console.ReadLine()
                    .Split("=", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Product product = new Product(curentProduct[0], int.Parse(curentProduct[1]));
                products.Add(product);
            }
        }
        public static void FillingPerson(List<Person> persons)
        {
            string[] peopleInt = Console.ReadLine()
              .Split(";", StringSplitOptions.RemoveEmptyEntries)
              .ToArray();
            for (int i = 0; i < peopleInt.Length; i++)
            {
                string[] curentPerson = Console.ReadLine()
                    .Split("=", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Person person = new Person(curentPerson[0], int.Parse(curentPerson[1]));
                persons.Add(person);
            }
        }
    }

    public class Product
    {
        public Product(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }

        public int Cost { get; set; }
    }

    public class Person
    {
        public List<string> bagOfProducts;

        public Person(string name, int money)
        {
            Name = name;
            Money = money;

            bagOfProducts = new List<string>();
        }

        public string Name { get; set; }

        public int Money { get; set; }
    }
}