
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

            BayProducts(persons , products);
            PrintWhatTheyBay(persons);

        }

        public static void PrintWhatTheyBay(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                if (person.bagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine(person);

                }
            }
        }
        public static void BayProducts(List<Person>persons , List<Product> products)
        {
            string curentArg;

            while ((curentArg = Console.ReadLine()) != "END")
            {
                string[] curentCouple = curentArg
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = curentCouple[0];
                string item = curentCouple[1];
                int price = products.First(x => x.Name == item).Cost;

                if (persons.Any(x => x.Name == name) && persons.First(x => x.Name == name).Money >= price)
                {
                    persons.First(x => x.Name == name).AddItem(item);
                    persons.First(x => x.Name == name).Money -= price;
                    Console.WriteLine($"{name} bought {item}");
                }
                else
                {
                    string curentName = persons.First(x => x.Name == name).Name;
                    Console.WriteLine($"{name} can't afford {item}");
                }
            }
        }

        public static void FillingProduct(List<Product> products)
        {
            string[] productInt = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < productInt.Length; i++)
            {
                string[] curentProduct = productInt[i]
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
                string[] curentPerson = peopleInt[i]
                    .Split("=", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = curentPerson[0];
                int money = int.Parse(curentPerson[1]);

                Person person = new Person(name, money);
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

            this.bagOfProducts = new List<string>();
        }

        public string Name { get; set; }

        public int Money { get; set; }

        public void AddItem(string item)
        {

            this.bagOfProducts.Add(item);
        }

        public override string ToString()
        {
            return $"{Name} - " + string.Join(", ", this.bagOfProducts);
        }
    }
}