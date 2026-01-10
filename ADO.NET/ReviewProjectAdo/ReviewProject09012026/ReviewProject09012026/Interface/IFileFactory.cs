using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewProject09012026.Interface
{
    public interface IFileFactory
    {
        IFileReader CreateReader();
        IFileWriter CreateWriter();
    }
}
