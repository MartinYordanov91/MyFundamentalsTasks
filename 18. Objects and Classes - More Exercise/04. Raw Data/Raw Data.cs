// You are the owner of a courier company and you want to make a system for tracking your cars and their cargo. Define
// a class Car that holds a piece of information about the model, engine and cargo. The Engine and Cargo should be
// separate classes. Create a constructor that receives all of the information about the Car and creates and initializes its
// inner components (engine and cargo).
// On the first line, of input you will receive a number N – the number of cars you have. On each of the next N lines, you
// will receive the following information about a car: "<Model> <EngineSpeed> <EnginePower> <CargoWeight>
// <CargoType>", where the speed, power and weight are all integers.
// After the N lines, you will receive a single line with one of 2 commands: "fragile" or "flamable". If the command
// is "fragile", print all cars, whose Cargo Type is "fragile" with cargo with weight < 1000. If the command is
// "flamable", print all of the cars whose Cargo Type is "flamable" and have Engine Power > 250. The cars should
// be printed in order of appearing in the input.

namespace _04._Raw_Data
{
    using System;
    internal class Program
    {
        static void Main()
        {
            List<ModelCar> cars = new List<ModelCar>();
            AddCarsData(cars);
            PrindValideModel(cars);
        }

        public static void PrindValideModel(List<ModelCar> cars)
        {
            string comand = Console.ReadLine();

            if (comand == "fragile")
            {
                foreach (var item in cars)
                {
                    if (item.Car.Type == comand && item.Car.Weight < 1000)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else
            {
                foreach (var item in cars)
                {
                    if (item.Car.Type == comand && item.Engine.Power > 250)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

        public static void AddCarsData(List<ModelCar> cars)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                ModelCar car = new ModelCar
                    (Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries));

                cars.Add(car);
            }
        }
    }

    public class ModelCar
    {
        public ModelCar(string[] modelData)
        {
            Model = modelData[0];
            Engine = new Engine(int.Parse(modelData[1]), int.Parse(modelData[2]));
            Car = new Car(int.Parse(modelData[3]), modelData[4]);

        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Car Car { get; set; }

        public override string ToString()
        {
            return $"{Model}";
        }

    }


    public class Engine
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }

        public int Speed { get; set; }

        public int Power { get; set; }
    }
    public class Car
    {
        public Car(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }

        public int Weight { get; set; }

        public string Type { get; set; }
    }
}