using HomeWork12.AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.AbstractFactory
{
    public class Chair : IChair
    {
        private string _type;
        public Chair(string type)
        {
            _type = type;
        }
        public void GetChair()
        {
            Console.WriteLine($"Here is your {_type} Chair");
        }
    }
}
