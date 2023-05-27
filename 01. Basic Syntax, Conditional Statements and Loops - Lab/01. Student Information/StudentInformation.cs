// 1. Student Information
// Create a program that receives 3 lines of input:
// • student name
// • age
// • average grade
// Your task is to print all of the info about the student in the following format: "Name: {student name}, Age:
// {student age}, Grade: {student grade}".


using System;

namespace _01._Student_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {averageGrade:f2}");
        }
    }
}