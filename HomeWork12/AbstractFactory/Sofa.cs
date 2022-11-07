using HomeWork12.AbstractFactory.Contracts;
using System;

namespace HomeWork12.AbstractFactory
{
    public class Sofa : ISofa
    {
        private string _type;
        public Sofa(string type)
        {
            _type = type;
        }
        public void GetSofa()
        {
            Console.WriteLine($"Here is your {_type} Sofa");
        }
    }
}
