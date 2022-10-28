using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork9.Enums;

namespace HomeWork9.Employees.Entity
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Positions Positions { get; set; }
        public Dictionary<WeekDays, int> WorkedHours { get; set; }
        public double Salary { get; set; }
        public double Bonus { get; set; }
    }
}
