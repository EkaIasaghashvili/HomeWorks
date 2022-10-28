using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.StudentTask2
{
    public  class ClassRoom
    {
        private List<Student> _students;
        public ClassRoom(List<Student> students)
        {
            _students = students;
        }
        public void Print()
        {
            foreach (var student in _students)
            {
                student.Study();
                student.Write();
                student.Read();
                student.Relax();
            }
        }
    }
}
