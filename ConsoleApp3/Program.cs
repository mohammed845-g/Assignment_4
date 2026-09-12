using System;
using System.Collections;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
     class Program 
    {
        static void Main(string[] args )
        {
            Employee[] employees = new Employee[]
            {
                new Employee(1, "John Doe", 30, gender.Male, new HiringDate(1, 1, 2020), "Software Engineer", 80000, SecurityLevel.Developer),
                new Employee(2, "Jane Smith", 28, gender.Female, new HiringDate(15, 3, 2019), "Product Manager", 90000, SecurityLevel.DBA),
                new Employee(3, "Mike Johnson", 35, gender.Male, new HiringDate(10, 7, 2021), "Sales Associate", 70000, SecurityLevel.Secretary),
                new Employee(4, "Emily Davis", 32, gender.Female, new HiringDate(5, 5, 2018), "Cyber Security Analyst", 75000, SecurityLevel.Guest |
                                                                                                                             SecurityLevel.Developer |
                                                                                                                             SecurityLevel.Secretary |
                                                                                                                             SecurityLevel.DBA)
            };



            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}

