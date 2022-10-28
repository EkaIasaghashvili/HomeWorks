using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.StudentTask
{
    public class Student
    {
        public string  FirstName { get; set; }
        public int Age { get; set; }
        public int YearOfStart { get; set; }

        public string GetRandomSubject(List<string> subjectList)
        {
            var random = new Random();
            int index = random.Next(subjectList.Count);
            return subjectList[index];
        }

        public int GetRemainYear()
        {
            //პირობაში ვერ მივხვდი წლების დათვლის პრინციპს, ამიტომ რანდომულად ვაბრუნებინებ წლებს.
            var random = new Random();
            return random.Next(4);
        }
    }
}
