using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.StudentTask2
{
    public class GoodStudent:Student
    {
        public override void Read()
        {
            Console.WriteLine($"{FirstName} likes reading");
        }
        public override void Study()
        {
            Console.WriteLine($"{FirstName} likes studing");
        }
        public override void Write()
        {
            Console.WriteLine($"{FirstName} likes writing");
        }
        public override void Relax()
        {
            Console.WriteLine($"{FirstName} don't like relax");
        }
    }
}
