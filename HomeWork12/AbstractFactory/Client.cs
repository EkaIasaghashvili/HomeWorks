using HomeWork12.AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.AbstractFactory
{
    public class Client
    {
        public void ClienRequest(IAbstractFactory factory)
        {
            ProcessRequest(factory);
        }

        public void ProcessRequest(IAbstractFactory factory)
        {
            var chair = factory.CreateChair();
            chair.GetChair();

            var sofa = factory.CreateSofa();
            sofa.GetSofa();

            var coffeeTable = factory.CreateCoffeeTable();
            
            coffeeTable.GetCoffeeTable();
        }
    }
}
