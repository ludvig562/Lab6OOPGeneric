using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6OOPGeneric
{
    internal class Employee
    {
        public int Id { get; set; } //properties for all teh employees
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, string gender, decimal salary) //konstruktor
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
    }
}
