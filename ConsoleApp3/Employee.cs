using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    [Flags]
    enum SecurityLevel
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8
    }
    enum gender
    {
        Male = 1,
        Female = 2,
    }
    internal class Employee
    {
        private int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public HiringDate HireDate { get; set; }

        SecurityLevel securityLevel { get; set; } = SecurityLevel.Guest;
        gender gender { get; set; } = gender.Male;

    public Employee(int id, string name, int age, gender gender, HiringDate hireDate, string position, int salary, SecurityLevel securityLevel)
        {
            Id = id;
            Name = name;
            Age = age;
            this.gender = gender;
            this.HireDate = hireDate;
            Position = position;
            Salary = salary;
     
            this.securityLevel = securityLevel;
        }

        public override string ToString()
        {
            return String.Format(
                "ID: {0}, Name: {1}, Security Level: {2}, Salary: {3:C}, Hire Date: {4}/{5}/{6}, Gender: {7}",
                Id,
                Name,
                securityLevel,
                Salary,
                HireDate.hireDay,
                HireDate.hireMonth,
                HireDate.hireYear,
                gender
            );
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age},gender: {gender}, Position: {Position}, Salary : {Salary}, Hire Date: {HireDate}, Security Level: {securityLevel}");
        }
        

    }
}
