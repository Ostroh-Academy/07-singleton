using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Використання Singleton для ведення журналу подій
        EventLogger.Instance.Log("Початок роботи системи");
        EventLogger.Instance.Log("Ініціалізація підсистеми A");
        EventLogger.Instance.Log("Ініціалізація підсистеми B");
        EventLogger.Instance.Log("Завершення роботи системи");

        List<string> logs = EventLogger.Instance.GetLogs();
        foreach (string log in logs)
        {
            Console.WriteLine(log);
        }
    }
}

public class EventLogger
{
    private static EventLogger instance;
    private List<string> logEntries;

    private EventLogger()
    {
        logEntries = new List<string>();
    }

    public static EventLogger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new EventLogger();
            }
            return instance;
        }
    }

    public void Log(string message)
    {
        logEntries.Add($"{DateTime.Now}: {message}");
    }

    public List<string> GetLogs()
    {
        return new List<string>(logEntries);
    }
}

