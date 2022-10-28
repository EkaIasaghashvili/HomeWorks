using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.StudentTask2
{
    public class Student
    {
        public string FirstName { get; set; }

        public virtual void Study() { }
        public virtual void Read() { }
        public virtual void Write() { }
        public virtual void Relax() { }
    }
}
