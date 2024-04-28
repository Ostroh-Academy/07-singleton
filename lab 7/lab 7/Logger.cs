using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_7
{
    public sealed class Logger
    {
        // Єдиний екземпляр класу Logger
        private static Logger instance = null;

        // Поле для зберігання шляху до лог-файлу
        private string logFilePath;

        // Об'єкт для блокування потоку під час створення екземпляра класу Logger
        private static readonly object padlock = new object();

        // Приватний конструктор
        private Logger()
        {
            // Ініціалізуємо шлях до лог-файлу
            logFilePath = "log.txt";
        }

        // Статичний метод для отримання єдиного екземпляра класу Logger
        public static Logger Instance
        {
            get
            {
                // Перевіряємо, чи екземпляр класу є вже створеним
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

        // Метод для запису повідомлення у лог-файл
        public void Log(string message)
        {
            // Відкриваємо або створюємо файл для запису
            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                // Записуємо повідомлення у файл
                sw.WriteLine($"{DateTime.Now} - {message}");
            }
        }
    }
}