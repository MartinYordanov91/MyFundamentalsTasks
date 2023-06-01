// Define a class called Student, which will hold the following information about some students:
// • first name
// • last name
// • age
// • home town
// Input / Constraints
// Read information about some students, until you receive the "end" command. After that, you will receive a city
// name.
// Output
// Print the students who are from the given city in the following format: "{firstName} {lastName} is {age}
// years old."


namespace _04._Students
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string informationInput = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (informationInput != "end")
            {
                List<string> stunedtInformation = informationInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                string firstName = stunedtInformation[0];
                string lastName = stunedtInformation[1];
                int age = int.Parse(stunedtInformation[2]);
                string homeTown = stunedtInformation[3];

                Student curentStudent = new Student(firstName , lastName , age , homeTown);
                students.Add(curentStudent);

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