using ReviewProject09012026.Interface;
using System;
using System.IO;

namespace ReviewProject09012026.Service
{
    public class JsonReader : IFileReader
    {
        public void Read(string path)
        {
            using StreamReader reader = new StreamReader(path);
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
