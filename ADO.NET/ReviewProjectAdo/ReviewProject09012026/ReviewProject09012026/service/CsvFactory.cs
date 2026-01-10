using ReviewProject09012026.Interface;
using System.Formats.Asn1;

namespace ReviewProject09012026.Service
{
    public class CsvFactory : IFileFactory
    {
        public IFileReader CreateReader() => new CsvReader();
        public IFileWriter CreateWriter() => new CsvWriter();
    }
}
