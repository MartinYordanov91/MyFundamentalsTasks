// You are given a working code that finds the volume of a pyramid. However, you should consider that the
// variables exceed their optimum span and have improper naming. Also, search for variables that have
// multiple purposes.

using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volumeOfPyramid = 0;


            Console.Write("Length: ");
            double Length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double Width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double Heigth = double.Parse(Console.ReadLine());

            volumeOfPyramid = ((Length * Width) * Heigth) / 3;
            Console.Write($"Pyramid Volume: {volumeOfPyramid:f2}");
        }
    }
}