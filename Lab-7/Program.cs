using System;
using System.Threading.Tasks;

public class LogManager
{
    private static LogManager _instance;
    private static readonly object _lock = new object();
    private string _logFile = "app_logs.txt";

    private LogManager() { }

    public static LogManager Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new LogManager();
                }
                return _instance;
            }
        }
    }

    public void Log(string message)
    {
        lock (_lock)
        {
            Console.WriteLine($"Logging: {message}");
            // Симулюємо запис у файл, затримку та випадок виключення для цікавості
            Task.Delay(1000).Wait();
            try
            {
                throw new Exception("Приклад винятку");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Parallel.Invoke(
            () => { LogManager.Instance.Log("Повідомлення 1"); },
            () => { LogManager.Instance.Log("Повідомлення 2"); },
            () => { LogManager.Instance.Log("Повідомлення 3"); }
        );

        // Затримка для зручності спостереження за виводом
        Console.ReadLine();
    }
}
