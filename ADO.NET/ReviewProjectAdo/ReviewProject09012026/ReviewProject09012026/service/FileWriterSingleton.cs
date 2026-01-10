using System.IO;

namespace ReviewProject09012026.service
{
    public sealed class FileWriterSingleton
    {
        private static StreamWriter _writer;
        private static readonly object _lock = new object();

        private FileWriterSingleton() { }

        public static StreamWriter GetWriter(string path)
        {

            //“First I check if the writer already exists. If not, I lock the code so only one thread can create it. Inside the lock,
            //I check again to ensure it wasn’t created by another thread. This guarantees only one writer is created.”
            if (_writer == null)
            {
                lock (_lock)
                {
                    if (_writer == null)   //this pattern is called double checked locking.
                    {
                        _writer = new StreamWriter(path, true);
                    }
                }
            }
            return _writer;
        }

        public static void Close()
        {
            _writer?.Close();
            _writer = null;
        }
    }
}
