using HomeWork12.Strategy.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.Strategy
{
    public class ZipFile : IStrategy
    {
        public void Process()
        {
            string zipPath = @"c:\Users\user\source\repos\HomeWorks\HomeWork12\Strategy\Files\file.zip";
            string extractPath = @"c:\Users\user\source\repos\HomeWorks\HomeWork12\Strategy\backup";


            System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath,true);
            Console.WriteLine("Zip file is unzip in backup folder");
        }
    }
}
