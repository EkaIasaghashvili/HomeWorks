using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10.AbstractFileWorker
{
    public abstract class FileWorkerBase
    {
        public int FileMaxSize { get; set; }
        public abstract string FileExpansion { get; set; }


        public virtual void Read() { }
        public virtual void Write() { }
        public virtual void Edit() { }
        public virtual void Delete() { }

    }
}
