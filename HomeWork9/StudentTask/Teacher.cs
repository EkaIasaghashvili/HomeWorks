using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.StudentTask
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public bool IsCertified { get; set; }

        public void GetTeacherCompetence(string subjectName)
        {   int num = 5;
            int num1 = 7;

            if (subjectName.Equals("Mathematics"))
            {
                Console.WriteLine(num + num1);
            }

            else if (subjectName.Equals("Chemistry"))
            {
                Console.WriteLine("H2O");
            }
            else if (subjectName.Equals("English"))
            {
                Console.WriteLine("Hello World");
            }
            else
            {
               Console.WriteLine("No Competence in this Subject");
            } 

        }
    }
}
