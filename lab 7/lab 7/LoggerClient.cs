using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    public class LoggerClient
    {
        private static LoggerClient _instance;
        private List<LogMessage> _logMessages;

        private LoggerClient()
        {
            _logMessages = new List<LogMessage>();
        }

        public static LoggerClient GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LoggerClient();
            }
            return _instance;
        }

        public void Log(string message)
        {
            var logMessage = new LogMessage(message);
            _logMessages.Add(logMessage);
        }

        public void PrintLog()
        {
            Console.WriteLine("Logged messages:");
            foreach (var logMessage in _logMessages)
            {
                Console.WriteLine(logMessage);
            }
        }
    }
}