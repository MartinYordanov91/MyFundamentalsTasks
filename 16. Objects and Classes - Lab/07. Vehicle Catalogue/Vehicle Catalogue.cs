// Your task is to create a Vehicle catalog, which contains only Trucks and Cars.
// Define a class Truck with the following properties: Brand, Model, and Weight.
// Define a class Car with the following properties: Brand, Model, and Horse Power.
// Define a class Catalog with the following properties: Collections of Trucks and Cars.
// You must read the input, until you receive the "end" command. It will be in following format:
// "{type}/{brand}/{model}/{horse power / weight}"
// In the end, you have to print all of the vehicles ordered alphabetical by brand, in the following format:
// "Cars:
// {Brand}: {Model} - {Horse Power}hp
// Trucks:
// {Brand}: {Model} - {Weight}kg"
// Hints
// This is how your class Catalog should look like.
// Don't forget to create instances for the two lists.
// You can do it in the constructor of CatalogueVehicle.


namespace _07._Vehicle_Catalogue
{
    using System;
    using System.Reflection;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Catalog catalog = new Catalog();
            bool isTruck = false;
            bool isCar = false;

            while (input != "end")
            {
                List<string> vehicle = input.Split("/").ToList();

                string type = vehicle[0];
                string brand = vehicle[1];
                string model = vehicle[2];
                string variation = vehicle[3];

                if (type == "Truck")
                {
                    Truck trucks = new Truck(brand, model, variation);
                    catalog.Trucks.Add(trucks);
                    isTruck = true;
                }
                else if (type == "Car")
                {
                    Car cars = new Car(brand, model, variation);
                    catalog.Carss.Add(cars);
                    isCar = true;
                }

                input = Console.ReadLine();
            }

            if (isCar)
            {
                Console.WriteLine("Cars:");

                foreach (var car in catalog.Carss.OrderBy(x => x.Brand))
                {
                    Console.WriteLine(car);
                }
            }

            if (isTruck)
            {
                Console.WriteLine("Trucks:");

                foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine(truck);
                }
            }
        }
    }

    public class Catalog
    {
        public Catalog()
        {
            Carss = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Carss { get; set; }

        public List<Truck> Trucks { get; set; }

    }
    public class Car
    {
        public Car(string brand, string model, string horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string HorsePower { get; set; }

        public override string ToString()
        {
            return $"{Brand}: {Model} - {HorsePower}hp";
        }
    }
    public class Truck
    {
        public Truck(string brand, string model, string weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Weight { get; set; }

        public override string ToString()
        {
            return $"{Brand}: {Model} - {Weight}kg";
        }
    }
}