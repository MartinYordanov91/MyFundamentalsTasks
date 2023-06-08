namespace _05._Courses
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            AddCoursesAndStudents(courses);
            PrintThemAll(courses);
        }
        public static void PrintThemAll(Dictionary<string, List<string>> courses)
        {
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var item in course.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }

        public static void AddCoursesAndStudents(Dictionary<string, List<string>>  courses)
        {
            string comandArg = string.Empty;
            while ((comandArg = Console.ReadLine()) != "end")
            {
                string[] courseArg = comandArg
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string course = courseArg[0];
                string student = courseArg[1];

                if (courses.ContainsKey(course))
                {
                    if (courses.First(k => k.Key == course).Value.Contains(student) == false)
                    {
                        courses.First(k => k.Key == course).Value.Add(student);
                    }
                }
                else
                {
                    courses.Add(course, new List<string>() { student });
                }
            }
        }
    }
}