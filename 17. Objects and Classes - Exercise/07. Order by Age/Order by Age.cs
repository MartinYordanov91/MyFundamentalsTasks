// You will receive an unknown number of lines. On each line you will receive an array with 3 elements:
// • The first element is a string - the name of the person
// • The second element a string - the ID of the person
// • The third element is an integer - the age of the person
// If you get a person whose ID you have already received before, update the name and age for that ID with that of
// the new person. When you receive the command "End", print all of the people, ordered by age. 



namespace _07._Order_by_Age
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            FillPerson(personList);
            OredAndPrint(personList);
        }

        static void OredAndPrint (List<Person> personList)
        {
            List<Person> list = personList.OrderBy(x => x.Age).ToList();
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }
        }
        static void FillPerson(List<Person> personList)
        {
            string comandArg;
            while ((comandArg = Console.ReadLine()) != "End")
            {
                string[] curentPerson = comandArg
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = curentPerson[0];
                string id = curentPerson[1];
                int age = int.Parse(curentPerson[2]);

                if (personList.Any(c => c.Id == id))
                {
                    personList.First(c => c.Id == id).Name = name;
                    personList.First(c => c.Id == id).Age = age;
                }
                else
                {
                    Person person = new Person(name, id, age);
                    personList.Add(person);
                }

            }
        }
    }

    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}