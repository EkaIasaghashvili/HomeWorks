using HomeWork12.AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.AbstractFactory
{
    public class ModernFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new Chair(nameof(ModernFactory));
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new CoffeeTable(nameof(ModernFactory));
        }

        public ISofa CreateSofa()
        {
            return new Sofa(nameof(ModernFactory));
        }
    }
}
