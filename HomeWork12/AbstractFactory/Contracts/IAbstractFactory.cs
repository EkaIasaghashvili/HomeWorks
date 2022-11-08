using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.AbstractFactory.Contracts
{
    public interface IAbstractFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ICoffeeTable CreateCoffeeTable();
    }
}
