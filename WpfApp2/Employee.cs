using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string position, int salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }
    }
}
