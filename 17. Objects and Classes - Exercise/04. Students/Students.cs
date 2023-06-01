// Create a program that sorts some students by their grade in descending order. Each student should have:
// • First name (string)
// • Last name (string)
// • Grade (a floating-point number)
// Input
// • On the first line, you will receive a number n - the count of all students.
// • On the next n lines, you will be receiving information about these students in the following format:
// "{first name} {second name} {grade}".
// Output
// • Print out the information about each student in the following format: "{first name} {second name}:
// {grade}".

namespace _04._Studentsss
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();

            for (int i = 0; i < studentsCount; i++)
            {
                List<string> curentStudent = Console.ReadLine().Split(" " , StringSplitOptions.RemoveEmptyEntries).ToList();
                Students curent = new Students(curentStudent[0] , curentStudent[1] , double.Parse(curentStudent[2]));
                students.Add(curent);

            }

            foreach (Students student in students.OrderByDescending(x=> x.Grade))
            {
                Console.WriteLine(student);
            }
        }
    }

    public class Students
    {
        public Students(string firstname , string lastname , double grade)
        {
            this.FirstName= firstname;
            this.LastName= lastname;
            this.Grade= grade;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}