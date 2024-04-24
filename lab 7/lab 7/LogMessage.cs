using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    public class LogMessage
    {
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }

        public LogMessage(string message)
        {
            Message = message;
            Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Timestamp} - {Message}";
        }
    }
}