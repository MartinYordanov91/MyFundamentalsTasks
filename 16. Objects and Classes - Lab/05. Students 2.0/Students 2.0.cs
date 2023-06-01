// Use the class from the previous problem. If you receive a student, which already exists (first name and last name
// should be unique) overwrite the information.
// Hints
// Check if the given student already exists.
// Overwrite the student information.
// First, we have to find the existing student.
// Finally, we have to overwrite the information.
// We can use LINQ as well.
// FirstOrDefault returns the first occurrence or the default value (null in this case). 

namespace _04._Students
{
    using System;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    internal class Program
    {
        static void Main(string[] args)
        {
            string informationInput = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (informationInput != "end")
            {
                List<string> stunedtInformation = informationInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                bool exist = false;

                string firstName = stunedtInformation[0];
                string lastName = stunedtInformation[1];
                int age = int.Parse(stunedtInformation[2]);
                string homeTown = stunedtInformation[3];

                foreach (var sdents in students)
                {
                    if ((sdents.FirstName == firstName && sdents.LastName == lastName))
                    {
                        sdents.Age = age;
                        sdents.HomeTown = homeTown;
                        exist = true;
                    }
                }

                if (!exist)
                {
                    Student curentStudent = new Student(firstName, lastName, age, homeTown);
                    students.Add(curentStudent);
                }

                informationInput = Console.ReadLine();
            }

            string fromCity = Console.ReadLine();

            students = students.Where(x => x.HomeTown == fromCity).ToList();

            foreach (var person in students)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old.");
            }

        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} {this.Age} {this.HomeTown}";
        }
    }
}