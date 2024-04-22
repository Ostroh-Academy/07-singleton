using System;
using System.IO;

// Інтерфейс для логування
public interface ILogger
{
    void Log(string message);
}

// Реалізація логера
public class Logger : ILogger
{
    private static Logger _instance;
    private string logFilePath;

    private Logger()
    {
        // Ініціалізація шляху до файлу логів
        logFilePath = "logs.txt";
    }

    public static Logger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Logger();
        }
        return _instance;
    }

    public void Log(string message)
    {
        // Запис повідомлення у файл
        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.WriteLine($"[{DateTime.Now}] {message}");
        }
    }
}

// Клас будівельника для системи логування
public class LoggingSystemBuilder
{
    private ILogger logger;

    public LoggingSystemBuilder()
    {
        // Ініціалізація системи логування з використанням Logger
        logger = Logger.GetInstance();
    }

    public ILogger Build()
    {
        return logger;
    }
}

// Клас, який використовує систему логування
public class Application
{
    private ILogger logger;

    public Application(ILogger logger)
    {
        this.logger = logger;
    }

    public void DoSomething()
    {
        // Приклад використання системи логування
        logger.Log("Виконується деяка дія...");
    }
}

// Головний клас програми
class Program
{
    static void Main(string[] args)
    {
        // Створення будівельника для системи логування
        LoggingSystemBuilder builder = new LoggingSystemBuilder();

        // Отримання екземпляру системи логування
        ILogger logger = builder.Build();

        // Створення додатку з використанням системи логування
        Application app = new Application(logger);

        // Виклик методу додатку
        app.DoSomething();

        Console.WriteLine("Логи були записані у файл.");
    }
}
