using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Отримуємо єдиний екземпляр LoggerClient
            LoggerClient logger = LoggerClient.GetInstance();

            // Логуємо кілька повідомлень
            logger.Log("Message 1");
            logger.Log("Message 2");
            logger.Log("Message 3");

            // Виводимо лог у консоль
            logger.PrintLog();

            Console.ReadLine(); // Чекаємо натискання Enter перед закриттям консолі
        }
    }
}