using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10.AbstractFileWorker
{
    public class FileWorker : FileWorkerBase
    {
        public override string FileExpansion { get; set; }


        public void Print()
        {
            Write();
            Read();
            Delete();
            Edit();
        }
        public override void Write()
        {
            Console.WriteLine($"I can write {FileExpansion} file with max storage {FileMaxSize}");
        }
        public override void Read()
        {
            Console.WriteLine($"I can read {FileExpansion} file with max storage {FileMaxSize}");
        }
        public override void Delete()
        {
            Console.WriteLine($"I can delete {FileExpansion} file with max storage {FileMaxSize}");
        }

        public override void Edit()
        {
            Console.WriteLine($"I can edit {FileExpansion} file with max storage {FileMaxSize}");
        }
    }
}
