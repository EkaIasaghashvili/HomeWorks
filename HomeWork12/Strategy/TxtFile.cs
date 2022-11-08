using HomeWork12.Strategy.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.Strategy
{
    public class TxtFile : IStrategy
    {
        public void Process()
        {
            string txtPath = @"C:\Users\user\source\repos\HomeWorks\HomeWork12\Strategy\Files\delete.txt";
            if (File.Exists(txtPath))
            {
                File.Delete(txtPath);
                Console.WriteLine("Txt file deleted");
            }
            else
            {
                Console.WriteLine("file doesn't exist");
            }
        }
    }
}
