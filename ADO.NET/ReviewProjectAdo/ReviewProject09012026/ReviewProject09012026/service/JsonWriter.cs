using ReviewProject09012026.Interface;
using ReviewProject09012026.service;

namespace ReviewProject09012026.Service
{
    public class JsonWriter : IFileWriter
    {
        public void Write(string path, string data)
        {
            var writer = FileWriterSingleton.GetWriter(path);
            writer.WriteLine(data);
            writer.Flush();
        }
    }
}
