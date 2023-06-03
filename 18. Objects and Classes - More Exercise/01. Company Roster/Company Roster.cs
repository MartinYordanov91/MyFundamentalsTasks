// Define a class Employee that holds the following information: a name, a salary and a department.
// Your task is to write a program, which takes N lines of employees from the console, calculates the department with
// the highest average salary, and prints for each employee in that department their name and salary – sorted by salary
// in descending order. The salary should be rounded to two digits after the decimal separator

namespace _01._Company_Roster
{
    using System;
    using System.Security.Cryptography.X509Certificates;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            FillEmployeesList(employees);
           
            List<Employee> average = new List<Employee>();
            AverageSalary(employees, average);

            PrintHigerAverageSalaryDepartament(average);
            PrintEmployeeDepartament(employees, average);
        }

        static void PrintEmployeeDepartament(List<Employee> employees , List<Employee> average)
        {
            average = average.OrderByDescending(x => x.Salary).ToList();
            string departamentHigAverageSalary = average[0].Departament;
            List<Employee> printEmployee = employees
                .Where(x => x.Departament == departamentHigAverageSalary)
                .OrderByDescending(x => x.Salary)
                .ToList();

            foreach (Employee employee in printEmployee)
            {
                Console.WriteLine(employee);
            }
        }
        static void PrintHigerAverageSalaryDepartament(List<Employee> average)
        {
            average = average.OrderByDescending(x => x.Salary).ToList();
            string departamentHigAverageSalary = average[0].Departament;
            Console.WriteLine($"Highest Average Salary: {departamentHigAverageSalary}");
        }
        static void AverageSalary(List<Employee> employees , List<Employee> average)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                string curentDnt = employees[i].Departament;

                if (average.Any(x => x.Departament == curentDnt))
                {
                    
                    average.First(x => x.Departament == curentDnt).Salary += employees[i].Salary;
                }
                else
                {
                   string[] strings = employees[i].ToString().Split(' ');
                    string name = "null" + i;
                    decimal salary = decimal.Parse(strings[1]);
                    string departament = curentDnt;
                    Employee newEmplo = new Employee(name , salary , departament);
                    average.Add(newEmplo);
                }
            }

            for (int i = 0; i < average.Count; i++)
            {
                int divisor = 0;
                string curentDnt = average[i].Departament;

                for (int n = 0; n < employees.Count; n++)
                {
                    string dnt = employees[n].Departament;
                    if (curentDnt == dnt)
                    {
                        divisor++;
                    }
                }
                average[i].Salary /= divisor;
            }
        }
        static void FillEmployeesList(List<Employee> employees)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] comandArg = Console.ReadLine().Split();

                string name = comandArg[0];
                decimal salary = decimal.Parse(comandArg[1]);
                string departament = comandArg[2];

                Employee employee = new Employee(name, salary, departament);
                employees.Add(employee);
            }
        }
    }

    public class Employee
    {
        public Employee(string name, decimal salary, string departament)
        {
            Name = name;
            Salary = salary;
            Departament = departament;
        }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Departament { get; set; }

        public override string ToString()
        {
            return $"{Name} {Salary:f2}";
        }
    }
}