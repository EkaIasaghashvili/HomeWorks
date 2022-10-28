using HomeWork9.Employees.Entity;
using HomeWork9.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.Data
{
    public static class EmployeeData
    {
        public static List<Employee> EmployeeList = new List<Employee>()
        {
            new Employee()
            {
                FirstName = "White",
                LastName = "Walker",
                Age = 50,
                Positions = Positions.Maneger,
                WorkedHours = new Dictionary<WeekDays, int>()
                {
                    {WeekDays.Monday, 10},
                    {WeekDays.Tuesday, 8},
                    {WeekDays.Wednesday, 8},
                    {WeekDays.Thursday, 8},
                    {WeekDays.Friday, 8},
                    {WeekDays.Saturday, 0},
                    {WeekDays.Sunday, 0}
                }
            },
            new Employee()
            {
                FirstName = "Jonn",
                LastName = "Snow",
                Age = 30,
                Positions = Positions.Developer,
                WorkedHours = new Dictionary<WeekDays, int>()
                {
                    {WeekDays.Monday, 10},
                    {WeekDays.Tuesday, 10},
                    {WeekDays.Wednesday, 10},
                    {WeekDays.Thursday, 10},
                    {WeekDays.Friday, 10},
                    {WeekDays.Saturday, 5},
                    {WeekDays.Sunday, 0}
                }
            },
            new Employee()
            {
                FirstName = "Daenerys",
                LastName = "Targaryen",
                Age = 25,
                Positions = Positions.Tester,
                WorkedHours = new Dictionary<WeekDays, int>()
                {
                    {WeekDays.Monday, 8},
                    {WeekDays.Tuesday, 8},
                    {WeekDays.Wednesday, 8},
                    {WeekDays.Thursday, 8},
                    {WeekDays.Friday, 8},
                    {WeekDays.Saturday, 0},
                    {WeekDays.Sunday, 0}
                }
            },
            new Employee()
            {
                FirstName = "Arya",
                LastName = "Stark",
                Age = 20,
                Positions = Positions.Other,
                WorkedHours = new Dictionary<WeekDays, int>()
                {
                    {WeekDays.Monday, 8},
                    {WeekDays.Tuesday, 8},
                    {WeekDays.Wednesday, 8},
                    {WeekDays.Thursday, 8},
                    {WeekDays.Friday, 8},
                    {WeekDays.Saturday, 0},
                    {WeekDays.Sunday, 0}
                }
            }
        };

        public static string CompanyLocation = "Georgia";
    }
}
