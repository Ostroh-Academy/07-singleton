using System;

namespace Singleton.Printer
{
    public sealed class PDFPrinter
    {
        private PDFPrinter() { }

        private static PDFPrinter _instance;

        public static PDFPrinter GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PDFPrinter();
            }
            return _instance;
        }

        public void PrintPDF(string source)
        {
            Console.WriteLine("Друк PDF з джерела: " + source);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PDFPrinter pdfPrinter = PDFPrinter.GetInstance();

            pdfPrinter.PrintPDF("Лекційний матеріал");
            pdfPrinter.PrintPDF("Наукова стаття");
            pdfPrinter.PrintPDF("Дипломна робота");

        }
    }
}