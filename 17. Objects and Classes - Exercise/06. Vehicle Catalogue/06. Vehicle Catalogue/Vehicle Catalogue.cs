// Until you receive the "End" command, you will be receiving lines of input in the following format:
// "{typeOfVehicle} {model} {color} {horsepower}"
// When you receive the "End" command, you will start receiving information about some vehicles.
// For every vehicle, print out the information about it in the following format:
// "Type: {typeOfVehicle}
// Model: {modelOfVehicle}
// Color: {colorOfVehicle}
// Horsepower: {horsepowerOfVehicle}"
// When you receive the "Close the Catalogue" command, print out the average horsepower of the cars and the
// average horsepower of the trucks in the format:
// "{typeOfVehicles} have average horsepower of {averageHorsepower}."
// The average horsepower is calculated by dividing the sum of the horsepower of all vehicles of the given type by
// the total count of all vehicles from that type. Format the answer to the second digit after the decimal point.
// Constraints
// • The type of vehicle will always be either a car or a truck.
// • You will not receive the same model twice.
// • The received horsepower will be an integer in the range [1…1000].
// • You will receive at most 50 vehicles.
// • The separator will always be single whitespace

namespace _06._Vehicle_Catalogue
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main()
        {
            List<VehicleCatalog> vehicle = new List<VehicleCatalog>();

            FillCatalog(vehicle);
            // UperFirsCharOfType(vehicle);
            PrintChoiseVehicle(vehicle);
            PrintAverageHorsePower(vehicle, "car");
            PrintAverageHorsePower(vehicle, "truck");



        }
        public static void UperFirsCharOfType(List<VehicleCatalog> vehicle)
        {
            foreach (var item in vehicle.Where(m => m.Type == "car"))
            {
                item.Type = "Car";
            }

            foreach (var item in vehicle.Where(m => m.Type == "truck"))
            {
                item.Type = "Truck";
            }
        }

        public static void PrintAverageHorsePower(List<VehicleCatalog> vehicle, string type)
        {
            List<VehicleCatalog> typeVehicle = new List<VehicleCatalog>();

            foreach (var item in vehicle.Where(v => v.Type == type))
            {
                typeVehicle.Add(item);
            }


            int carscount = typeVehicle.Count;
            double averageCarseHorsepower = 0;
            foreach (var item in typeVehicle)
            {
                averageCarseHorsepower += item.Horsepower;
            }
            if (typeVehicle.Count == 0)
            {
                averageCarseHorsepower = 0.00;
            }
            else
            {
                averageCarseHorsepower /= carscount;
            }


            Console.WriteLine($"{(type == "car" ? "Car" : "Truck")}s have average horsepower of: {averageCarseHorsepower:f2}.");


        }
        public static void PrintChoiseVehicle(List<VehicleCatalog> vehicle)
        {
            string model;
            while ((model = Console.ReadLine()) != "Close the Catalogue")
            {
                VehicleCatalog prind = vehicle.First(v => v.Model == model);

                Console.WriteLine($"{prind}");

                //foreach (var take in vehicle.Where(v => v.Model == model))
                //{
                //    Console.WriteLine($"{take}");
                //}


            }
        }
        public static void FillCatalog(List<VehicleCatalog> vehicle)
        {
            string comandArgs;
            while ((comandArgs = Console.ReadLine()) != "End")
            {
                string[] curentVehicle = comandArgs
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = curentVehicle[0];
                string model = curentVehicle[1];
                string color = curentVehicle[2];
                int horsepower = int.Parse(curentVehicle[3]);

                VehicleCatalog newVehicle = new VehicleCatalog(type, model, color, horsepower);
                vehicle.Add(newVehicle);
            }
        }
    }

    public class VehicleCatalog
    {

        public VehicleCatalog(string type, string model, string color, int horsepower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {(this.Type == "car" ? "Car" : "Truck")}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Color: {this.Color}");
            sb.AppendLine($"Horsepower: {this.Horsepower}");
            // return $"Type: {(this.Type == "car" ? "Car" : "Truck")}\nModel: {this.Model}\nColor: {this.Color}\nHorsepower: {this.Horsepower}";
            return sb.ToString().TrimEnd();
        }
    }
}