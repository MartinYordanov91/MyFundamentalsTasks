// You are given the coordinates of two points on a Cartesian coordinate system - X1, Y1, X2, and Y2. Create a method
// that prints the point that is closest to the center of the coordinate system (0, 0) in the format (X, Y). If the points are
// at the same distance from the center, print only the first one.

using System;

namespace _02._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xOne = double.Parse(Console.ReadLine());
            double yOne = double.Parse(Console.ReadLine());
            double xTwo = double.Parse(Console.ReadLine());
            double yTwo = double.Parse(Console.ReadLine());

            CloseToCenter(xOne, yOne, xTwo, yTwo);
        }

        static void CloseToCenter(double xOne, double yOne, double xTwo, double yTwo)
        {
            double sumFirst = Math.Abs(xOne) + Math.Abs(yOne);
            double sumSecond = Math.Abs(xTwo) + Math.Abs(yTwo);

            if (sumFirst == sumSecond)
            {
                Console.WriteLine("({0}, {1})", xOne, yOne);
            }
            else if (sumFirst < sumSecond)
            {
                Console.WriteLine("({0}, {1})", xOne, yOne);
            }
            else if (sumFirst > sumSecond)
            {
                Console.WriteLine("({0}, {1})", xTwo, yTwo);
            }
        }
    }
}