// You are given the coordinates of four points in the 2D plane. The first and the second pair of points form two
// different lines. Print the longer line in the format "(X1, Y1)(X2, Y2)" starting with the point that is closer to the 
// center of the coordinate system (0, 0). (You can reuse the method that you wrote for the previous problem.) If the
// lines are of equal length, print only the first one

using System;

namespace _03._Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arrayOfNumbers = new double[8];

            for (int i = 0; i < 8; i++)
            {
                arrayOfNumbers[i] = double.Parse(Console.ReadLine());
            }
            //Console.WriteLine(string.Join(" , ", arrayOfNumbers));


            double firstCordinateSistem = 0;
            firstCordinateSistem = SumFirst(arrayOfNumbers, firstCordinateSistem);

            double SecondCordinateSistem = 0;
            SecondCordinateSistem = SumSecond(arrayOfNumbers, SecondCordinateSistem);

            double xOne, yOne, xTwo, yTwo;
            LongerLineCordinates(arrayOfNumbers, firstCordinateSistem, SecondCordinateSistem, out xOne, out yOne, out xTwo, out yTwo);

            CloseToCenter(xOne, yOne, xTwo, yTwo);
        }

        static void LongerLineCordinates(double[] arrayOfNumbers, double firstCordinateSistem, double SecondCordinateSistem, out double xOne, out double yOne, out double xTwo, out double yTwo)
        {
            xOne = 0;
            yOne = 0;
            xTwo = 0;
            yTwo = 0;
            if (firstCordinateSistem >= SecondCordinateSistem)
            {
                xOne = arrayOfNumbers[0];
                yOne = arrayOfNumbers[1];
                xTwo = arrayOfNumbers[2];
                yTwo = arrayOfNumbers[3];

            }
            else
            {
                xOne = arrayOfNumbers[4];
                yOne = arrayOfNumbers[5];
                xTwo = arrayOfNumbers[6];
                yTwo = arrayOfNumbers[7];
            }
        }

        static void CloseToCenter(double xOne, double yOne, double xTwo, double yTwo)
        {
            double sumFirst = Math.Abs(xOne) + Math.Abs(yOne);
            double sumSecond = Math.Abs(xTwo) + Math.Abs(yTwo);

            if (sumFirst <= sumSecond)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", xOne, yOne, xTwo, yTwo);
            }
            else if (sumFirst > sumSecond)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", xTwo, yTwo, xOne, yOne);
            }
        }

        static double SumSecond(double[] arrayOfNumbers, double SecondCordinateSistem)
        {
            for (int y = 4; y < 8; y++)
            {
                SecondCordinateSistem += Math.Abs(arrayOfNumbers[y]);
            }

            return SecondCordinateSistem;
        }

        static double SumFirst(double[] arrayOfNumbers, double firstCordinateSistem)
        {
            for (int i = 0; i < 4; i++)
            {
                firstCordinateSistem += Math.Abs(arrayOfNumbers[i]);
            }

            return firstCordinateSistem;
        }
    }
}