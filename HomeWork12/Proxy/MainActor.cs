using HomeWork12.Proxy.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.Proxy
{
    public class MainActor : IActivity
    {
        public void Movie()
        {
            Console.WriteLine("Filming");
        }
    }
}
