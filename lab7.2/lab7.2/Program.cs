using System;
using System.IO;

public class Logger
{
    private static Logger instance;
    private static readonly object lockObject = new object();
    private string logFilePath = "log.txt";

    private Logger() { }

    public static Logger Instance
    {
        get
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
    }

    public void Log(string message)
    {
        try
        {
            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                sw.WriteLine($"{DateTime.Now}: {message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error logging message: {ex.Message}");
        }
    }
}

class Program
{
    static void Main()
    {
        Logger.Instance.Log("Application started");
        // Виконання дій
        Logger.Instance.Log("Some action occurred");
        // Додаткові дії
        Logger.Instance.Log("Application stopped");
    }
}
