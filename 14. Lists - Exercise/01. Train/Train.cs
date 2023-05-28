// On the first line, we will receive a list of wagons (integers). Each integer represents the number of passengers that
// are currently in each wagon of the passenger train. On the next line, you will receive the max capacity of a wagon,
// represented as a single integer. Until you receive the "end" command, you will be receiving two types of input:
// • Add {passengers} – add a wagon to the end of the train with the given number of passengers.
// • {passengers} – find a single wagon to fit all the incoming passengers (starting from the first wagon).
// In the end, print the final state of the train (all the wagons separated by a space).

using System;

namespace _01._Train___lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int MaxPassengerInWagons = int.Parse(Console.ReadLine());
            
            string comands = Console.ReadLine();

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] > MaxPassengerInWagons)
            //    {
            //        passenger += list[i] - MaxPassengerInWagons;
            //        list[i] = MaxPassengerInWagons;
            //    }
            //    else if (passenger > 0 && list[i] < MaxPassengerInWagons )
            //    {
            //        list[i] += passenger;
            //        passenger = 0;
            //        i = -1;

            //    }
            //}

            while (comands != "end")
            {
                if (comands.Contains("Add"))
                {
                    string[] split= comands.Split();
                    int passengers = int.Parse(split[1]);
                    
                    list.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(comands);

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] + passengers <= MaxPassengerInWagons)
                        {
                            list[i] += passengers;
                            break;
                        }

                    }

                }
                comands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" " , list));
        }
    }
}