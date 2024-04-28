namespace Printer
{
    using System;
    using System.Threading;

    public sealed class PrinterSingleton
    {
        private static PrinterSingleton _instance;

        private static readonly object _lock = new object();

        private PrinterSingleton()
        {
            Console.WriteLine("Принтер ініціалізовано.");
        }

        public static PrinterSingleton Instance
        {
            get
            {
                if (_instance == null) 
                {
                    lock (_lock) 
                    {
                        if (_instance == null) 
                        {
                            _instance = new PrinterSingleton();
                        }
                    }
                }
                return _instance;
            }
        }

        public void Print(string document)
        {
            Console.WriteLine($"Друкується документ: {document}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            void PrintJob(string document)
            {
                var printer = PrinterSingleton.Instance; 
                printer.Print(document); 
            }

            Thread thread1 = new Thread(() => PrintJob("Документ 1"));
            Thread thread2 = new Thread(() => PrintJob("Документ 2"));
            Thread thread3 = new Thread(() => PrintJob("Документ 3"));

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();
        }
    }

}
