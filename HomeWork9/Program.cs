using HomeWork9.Data;
using HomeWork9.Employees;
using HomeWork9.Employees.Entity;
using HomeWork9.StudentTask;
using HomeWork9.StudentTask2;
using System;
using System.Collections.Generic;
using Student = HomeWork9.StudentTask2.Student;

namespace HomeWork9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //var company = new Company
            //{
            //    IsLocal = EmployeeData.CompanyLocation.Equals("Georgia")
            //};

            //var calculations = new Calculations();
            //var employees = calculations.GetCalculatedSalary(EmployeeData.EmployeeList);
            //var calculatedTax = calculations.GetCalculatedTax(employees, company);

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.Positions}, Salary - {employee.Salary}, Bonus - {employee.Bonus}");
            //}

            //Console.WriteLine();
            //Console.WriteLine($"Calculated Tax - {calculatedTax}");
            #endregion
            #region Task2
            //var student = new Student();
            //string randomSubject = student.GetRandomSubject(StudentTaskData.SubjectList);
            //var teacher = new Teacher();
            //teacher.GetTeacherCompetence(randomSubject);

            #endregion
            #region Task3
            //var goodStudent = new GoodStudent();
            //goodStudent.FirstName = "George";

            //var lazyStudent = new LazyStudent();
            //lazyStudent.FirstName = "John";

            //var studentList = new List<Student>();
            //studentList.Add(goodStudent);
            //studentList.Add(lazyStudent);

            //var classRoom = new ClassRoom(studentList);
            //classRoom.Print();
            #endregion

            Console.ReadLine();

        }
    }
}
