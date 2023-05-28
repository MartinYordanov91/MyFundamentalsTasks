// Create a method that calculates and returns the area of a rectangle.

using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main()
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double area = 0;
            area = result(height, width);
            Console.WriteLine(area);
        }

        static double result(double height, double width)
        {
            return height * width;
        }
    }
}