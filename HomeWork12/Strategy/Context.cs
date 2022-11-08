using HomeWork12.Strategy.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.Strategy
{
    public class Context
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void FileOperation()
        {
            _strategy.Process();
        }
    }
}
