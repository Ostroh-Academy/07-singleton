using System;

namespace SingletonPattern
{
    public sealed class ConfigurationManager
    {
        private static readonly Lazy<ConfigurationManager> lazy = new Lazy<ConfigurationManager>(() => new ConfigurationManager());

        private string configValue;
        
        private ConfigurationManager()
        {
            // Simulate loading configuration
            configValue = "Initial Configuration Value";
        }

        public static ConfigurationManager Instance
        {
            get { return lazy.Value; }
        }

        public string GetConfigValue()
        {
            return configValue;
        }

        public void SetConfigValue(string value)
        {
            configValue = value;
        }
    }

    class Logger
    {
        private static readonly Lazy<Logger> lazy = new Lazy<Logger>(() => new Logger());

        private Logger() { }

        public static Logger Instance
        {
            get { return lazy.Value; }
        }

        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }

    class DatabaseConnection
    {
        private static readonly Lazy<DatabaseConnection> lazy = new Lazy<DatabaseConnection>(() => new DatabaseConnection());

        private string connectionString;

        private DatabaseConnection()
        {
            connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
        }

        public static DatabaseConnection Instance
        {
            get { return lazy.Value; }
        }

        public void OpenConnection()
        {
            Console.WriteLine("Database connection opened.");
        }

        public void CloseConnection()
        {
            Console.WriteLine("Database connection closed.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var configManager1 = ConfigurationManager.Instance;
            var configManager2 = ConfigurationManager.Instance;

            if (configManager1 == configManager2)
            {
                Console.WriteLine("ConfigurationManager: Singleton works, both variables contain the same instance.");
            }

            Console.WriteLine($"Configuration Value: {configManager1.GetConfigValue()}");
            configManager1.SetConfigValue("New Configuration Value");
            Console.WriteLine($"Configuration Value: {configManager2.GetConfigValue()}");

            var logger1 = Logger.Instance;
            var logger2 = Logger.Instance;

            if (logger1 == logger2)
            {
                Console.WriteLine("Logger: Singleton works, both variables contain the same instance.");
            }

            logger1.Log("Logging a message");

            var dbConnection1 = DatabaseConnection.Instance;
            var dbConnection2 = DatabaseConnection.Instance;

            if (dbConnection1 == dbConnection2)
            {
                Console.WriteLine("DatabaseConnection: Singleton works, both variables contain the same instance.");
            }

            dbConnection1.OpenConnection();
            dbConnection1.CloseConnection();
        }
    }
}
