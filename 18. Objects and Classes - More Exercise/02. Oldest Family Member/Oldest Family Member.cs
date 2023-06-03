// Create two classes – Family and Person. The Person class should have Name and Age properties. The Family class
// should have a list of people, a method for adding members (void AddMember(Person member)), and a method,
// which returns the oldest family member (Person GetOldestMember()). Write a program that reads the names
// and ages of N people and adds them to the family. Then print the name and age of the oldest member.

namespace _02._Oldest_Family_Member
{
    using System;
    
    internal class Program
    {
        static void Main()
        {
            List<Person> persons = new List<Person>();
            AddMember(persons);
            GetOldestMember(persons);
        }
        public static void GetOldestMember(List<Person> persons)
        {
            persons = persons.OrderByDescending(p => p.Age).ToList();
            Console.WriteLine(persons[0]);
        }
        public static void AddMember (List<Person> persons)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] curentArg = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = curentArg[0];
                int age = int.Parse(curentArg[1]);
                Person person = new Person(name, age);
                persons.Add(person);
            }
        }
    }

    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }

        public string Name { get; set; }    

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}