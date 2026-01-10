using ReviewProject09012026.Interface;
using ReviewProject09012026.service;

namespace ReviewProject09012026.Service
{
    public class JsonFactory : IFileFactory
    {
        public IFileReader CreateReader() => new JsonReader();
        public IFileWriter CreateWriter() => new JsonWriter();
    }
}
