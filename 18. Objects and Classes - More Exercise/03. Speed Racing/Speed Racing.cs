// Your task is to implement a program that keeps track of cars and their fuel and supports methods for moving the cars.
// Define a class Car that keeps a track of a car's model, fuel amount, fuel consumption per kilometer and traveled
// distance. A Car's model is unique - there will never be 2 cars with the same model.
// On the first line of the input, you will receive a number N – the number of cars you need to track. On each of the next
// N lines, you will receive information about cars in the following format "<Model> <FuelAmount>
// <FuelConsumptionFor1km>". All cars start at 0 kilometers traveled.
// After the N lines, until the command "End" is received, you will receive commands in the following format "Drive
// <CarModel> <amountOfKm>". Implement a method in the Car class to calculate whether or not a car can move
// that distance. If it can, the car's fuel amount should be reduced by the amount of used fuel and its traveled distance
// should be increased by the number of the traveled kilometers. Otherwise, the car should not move (its fuel amount
// and the traveled distance should stay the same) and you should print on the console "Insufficient fuel for
// the drive". After the "End" command is received, print each car, its current fuel amount and the traveled distance
// in the format "<Model> <fuelAmount> <distanceTraveled>". Print the fuel amount rounded to two digits
// after the decimal separator.

namespace _03._Speed_Racing
{
    using System;
    using System.Collections.Immutable;

    internal class Program
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            Addcars(cars);
            Drive(cars);
            Print(cars);
        }

        private static void Print(List<Car> cars)
        {
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }

        public static void Drive (List<Car> cars)
        {
            string comandArg;
            while ((comandArg = Console.ReadLine()) != "End")
            {
                string[] argoments = comandArg
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = argoments[1];
                double distance = double.Parse(argoments[2]);


                double fuelCurentCar = (cars.First(m => m.Model == model).Fuel);
                double fuelPerC = (cars.First(m => m.Model == model).FuelPerC);

                if (distance <= fuelCurentCar / fuelPerC)
                {
                    cars.First(m => m.Model == model).DistanceTravel += distance;
                    cars.First(m => m.Model == model).Fuel -= distance * fuelPerC;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

            }
        }
        public static void Addcars(List<Car> cars)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] comandArg = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = comandArg[0];
                double fuel = double.Parse(comandArg[1]);
                double fuelPerC = double.Parse(comandArg[2]);

                Car car = new Car(model, fuel, fuelPerC);
                cars.Add(car);
            }
        }
    }
    public class Car
    {

        public Car(string model, double fuel, double fuelPerC)
        {
            Model = model;
            Fuel = fuel;
            FuelPerC = fuelPerC;
            DistanceTravel = 0;
        }

        public string Model { get; set; }

        public double Fuel { get; set; }

        public double FuelPerC { get; set; }

        public double DistanceTravel { get; set; }


        public override string ToString()
        {
            return $"{Model} {Fuel:f2} {DistanceTravel}";
        }
    }
}