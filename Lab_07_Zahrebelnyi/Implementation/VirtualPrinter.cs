namespace Lab_07_Zahrebelnyi
{
    public class VirtualPrinter
    {
        private static VirtualPrinter _instance;
        private static readonly object _lock = new object();

        public static VirtualPrinter GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new VirtualPrinter();
                    }
                }
            }
            return _instance;
        }

        public void PrintEmployeeReport(string report)
        {
            Console.WriteLine("Printing Employee Report: ");
            Console.WriteLine(report);
        }

        public void PrintSalaryReport(string report)
        {
            Console.WriteLine("Printing Salary Report: ");
            Console.WriteLine(report);
        }

        public void PrintFinancialDocument(string document)
        {
            Console.WriteLine("Printing Financial Document: ");
            Console.WriteLine(document);
        }
    }
}