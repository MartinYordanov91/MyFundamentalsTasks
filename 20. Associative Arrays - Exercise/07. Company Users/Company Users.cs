namespace _07._Company_Users
{
    using System;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            var companys = new List<Company>();

            FillListCompanies(companys);
            PrintCompanies(companys);
        }
        public static void FillListCompanies(List<Company> companys)
        {
            string comandArg = string.Empty;

            while ((comandArg = Console.ReadLine()) != "End")
            {
                string[] companyArg = comandArg
                      .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                      .ToArray();

                string name = companyArg[0];
                string id = companyArg[1];
                Func<Company, bool> isNamenListed = n => n.Name == name;

                if (companys.Any(isNamenListed) == false)
                {
                    var company = new Company(name);
                    company.AddID(id);
                    companys.Add(company);
                }
                else
                {
                    if (IsContainsID(companys, companyArg) == false)
                    {
                        companys.First(n => n.Name == name).AddID(id);
                    }
                }
            }
        }

        public static void PrintCompanies(List<Company> companys)
        {

            foreach (var company in companys)
            {
                Console.Write(company);
            }
        }
        public static bool IsContainsID(List<Company> companys , string[] companyArg)
        {
            string name = companyArg[0];
            string id = companyArg[1];
            return companys.First(n => n.Name == name).employeeID.Contains(id);
        }
    }

    public class Company
    {
        public List<string> employeeID = new List<string>();

        public Company(string name)
        {
            Name = name;

            employeeID = new List<string>();
        }

        public string Name { get; set; }

        public void AddID(string  id)
        {
            this.employeeID.Add(id);
            
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            
            sb.AppendLine(Name); 
            foreach (var ID in employeeID)
            {
                sb.AppendLine($"-- {ID}");
            }
            return sb.ToString();
        }
    }
}