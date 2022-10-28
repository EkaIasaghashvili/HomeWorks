using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.StudentTask
{
    public static class StudentTaskData
    {
        public static List<Student> StudentList = new List<Student>()
        {
            new Student()
            {
                FirstName = "Tom",
                Age = 20,
                YearOfStart = 2020
            }
        };

        public static Teacher TeacherData = new Teacher()
        {
            FirstName = "Ann",
            IsCertified = true,
        };

        public static List<string> SubjectList = new List<string>()
        {
            "Mathematics", "Chemistry", "English", "Georgian"
        };
    }
}
