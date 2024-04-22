namespace Singleton.Example
{
    public sealed class Logger
    {
        private static Logger instance = null;
        private static readonly object padlock = new object();

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                    return instance;
                }
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.Instance;

            logger.Log("This is a log message.");
            logger.Log("Another log message.");
        }
    }
}
