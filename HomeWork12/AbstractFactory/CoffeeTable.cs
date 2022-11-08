using HomeWork12.AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.AbstractFactory
{
    public class CoffeeTable : ICoffeeTable
    {
        private string _type;
        public CoffeeTable(string type)
        {
            _type = type;
        }
        public void GetCoffeeTable()
        {
            Console.WriteLine($"Here is your {_type} CoffeeTable");
        }
    }
}
