using System;
using System.IO;

namespace Interfaces
{
    public class FileLogger : ILogger 
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log("Error", message);
        }
        public void LogInfo(string message)
        { 
            Log("Info", message);
        }
         
        private void Log(string messageType, string message)
        {
            try
            {
                using var stream = new StreamWriter(_path, true);
                stream.WriteLine(messageType + ": "+ message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}