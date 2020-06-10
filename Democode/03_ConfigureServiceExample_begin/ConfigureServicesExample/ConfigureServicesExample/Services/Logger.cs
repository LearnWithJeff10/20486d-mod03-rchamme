using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace ConfigureServicesExample.Services
{
    public class Logger : ILogger
    {
        private string _filename;

        public Logger()
        {
            _filename = $"{DateTime.UtcNow.ToString("yyyy-dd-MM-HH-mm-ss")}.log";
        }

        public void Log(string logDate)
        {
            File.AppendAllText(_filename, $"{DateTime.UtcNow}: {logDate}");
        }
    }
}
