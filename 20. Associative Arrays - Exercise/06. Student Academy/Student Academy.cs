namespace _06._Student_Academy
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, List<double>>();
            ListStudents(students);
            PrintStudentsAverageGrade(students);

        }
        public static void PrintStudentsAverageGrade(Dictionary<string, List<double>> students)
        {
            foreach (var student in students)
            {

                if (student.Value.Sum() / student.Value.Count >= 4.50)
                {
                    double grade = student.Value.Sum() / student.Value.Count;

                    Console.WriteLine($"{student.Key} -> {grade:f2}");
                }
            }
        }

        public static void ListStudents(Dictionary<string, List<double>> students)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(student))
                {
                    students[student].Add(grade);
                }
                else
                {
                    students.Add(student, new List<double>() { grade });
                }
            }
        }
    }
}