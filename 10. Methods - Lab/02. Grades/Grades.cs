// Create a method that receives a grade between 2.00 and 6.00 and prints the corresponding grade definition:
// • 2.00 – 2.99 - "Fail"
// • 3.00 – 3.49 - "Poor"
// • 3.50 – 4.49 - "Good"
// • 4.50 – 5.49 - "Very good"
// • 5.50 – 6.00 - "Excellent"


using System;

namespace _02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Corresponding(grade);
        }

        private static void Corresponding(double grade)
        {
            if (grade > 1.99 && grade < 3) { Console.WriteLine("Fail"); }
            else if (grade > 2.99 && grade < 3.5) { Console.WriteLine("Poor"); }
            else if (grade > 3.49 && grade < 4.5) { Console.WriteLine("Good"); }
            else if (grade > 4.49 && grade < 5.5) { Console.WriteLine("Very good"); }
            else if (grade > 5.49 && grade <= 6) { Console.WriteLine("Excellent"); }
        }
    }
}