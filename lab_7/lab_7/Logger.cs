using System;
namespace lab_7
{
    public class Logger
    {
        private static Logger instance;
        private static object lockObject = new object();

        private Logger() { }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }
            }
            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }
    }

}

