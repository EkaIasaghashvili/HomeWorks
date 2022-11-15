using HomeWork14.Models;
using System.Collections.Generic;

namespace HomeWork14.Contracts
{
    public interface IFile
    {
        List<PersonData> Read();
        void Write(List<PersonData> list);
    }
}
