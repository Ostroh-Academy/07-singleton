using Lab_07_Zahrebelnyi;

class Program
{
    static void Main(string[] args)
    {
        VirtualPrinter printer1 = VirtualPrinter.GetInstance();

        printer1.PrintEmployeeReport("Employee Report for April 2024");
        printer1.PrintSalaryReport("Salary Report for April 2024");
        printer1.PrintFinancialDocument("Quarterly Financial Statement");

        VirtualPrinter printer2 = VirtualPrinter.GetInstance();

        if (printer1 == printer2)
        {
            Console.WriteLine("printer1 and printer2 are the same instance.");
        }
        else
        {
            Console.WriteLine("printer1 and printer2 are different instances.");
        }
    }
}