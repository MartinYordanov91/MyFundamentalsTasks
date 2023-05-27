// Calculate how many courses will be needed to elevate n persons by using an elevator of the capacity of p
// persons. The input holds two lines: the number of people n and the capacity p of the elevator.

using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int elevateFit = int.Parse(Console.ReadLine());

            int count = 0;

            while (people > 0)
            {
                people -= elevateFit;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}