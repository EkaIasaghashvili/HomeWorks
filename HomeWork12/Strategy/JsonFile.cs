using HomeWork12.Strategy.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.Strategy
{
    public class JsonFile : IStrategy
    {
        public void Process()
        {
            var reader = new StreamReader(@"C:\Users\user\source\repos\HomeWorks\HomeWork12\Strategy\Files\Jsonj.json");
            string jsonString = reader.ReadToEnd();
            Console.WriteLine(jsonString);
        }
    }
}
