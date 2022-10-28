using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.StudentTask2
{
    public class LazyStudent:Student
    {
        public override void Read()
        {
            Console.WriteLine($"{FirstName} doesn't like reading");
        }
        public override void Study()
        {
            Console.WriteLine($"{FirstName} doesn't like studing");
        }
        public override void Write()
        {
            Console.WriteLine($"{FirstName} doesn't like writing");
        }
        public override void Relax()
        {
            Console.WriteLine($"{FirstName} likes relaxing");
        }
    }
}
