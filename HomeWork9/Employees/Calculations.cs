using HomeWork9.Employees.Constants;
using HomeWork9.Employees.Entity;
using HomeWork9.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.Employees
{
    public class Calculations
    {
        public List<Employee> GetCalculatedSalary(List<Employee> employeesList)
        {
            foreach (var employee in employeesList)
            {
                foreach (var weekHour in employee.WorkedHours)
                {
                    if (weekHour.Key <= WeekDays.Friday)
                    {
                        if (employee.WorkedHours[weekHour.Key] <= 8)
                            employee.Salary += CalculateStandartSalary(employee, weekHour);
                        else
                            employee.Salary += CalculateStandartSalary(employee, weekHour) + Compensations.CompensationOverTime * (employee.WorkedHours[weekHour.Key] - 8);
                    }
                    else
                        employee.Salary += CalculateStandartSalary(employee, weekHour) * 2;
                }
                employee.Bonus = CalculateBonus(employee);
            }
            return employeesList;
        }

        public double GetCalculatedTax(List<Employee> employeesList, Company company)
        {
            double sumSalary = employeesList.Sum(x => x.Salary);
            double sumBonus = employeesList.Sum(x => x.Bonus);
            if (company.IsLocal)
                return (sumSalary + sumBonus) * 0.18;
            else
                return (sumSalary + sumBonus) * 0.05;
        }

        private double CalculateStandartSalary(Employee employee, KeyValuePair<WeekDays, int> weekHour)
        {
            double salary = 0;
            switch (employee.Positions)
            {
                case Positions.Maneger:
                    salary = employee.WorkedHours[weekHour.Key] * Compensations.Manager;
                    break;
                case Positions.Developer:
                    salary = employee.WorkedHours[weekHour.Key] * Compensations.Developer;
                    break;
                case Positions.Tester:
                    salary = employee.WorkedHours[weekHour.Key] * Compensations.Tester;
                    break;
                case Positions.Other:
                    salary = employee.WorkedHours[weekHour.Key] * Compensations.Other;
                    break;
                default:
                    break;
            }
            return salary;
        }

        private double CalculateBonus(Employee employee)
        {
            if (employee.WorkedHours.Sum(x => x.Value) > 50)
                return employee.Salary * 0.2;
            return 0;
        }
    }
}
