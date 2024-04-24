namespace Laboratory7;

internal static class Program
{
    private static void Main(string[] args)
    {
        PdfPrinter printer = PdfPrinter.Instance;

        printer.PrintDocument("Mathematics Lecture Notes", "Introduction to Calculus...");
        printer.PrintDocument("Physics Lab Report", "Experiment Setup and Data Analysis...");
        printer.PrintDocument("Literature Essay", "Analysis of Shakespeare's Hamlet...");

        Console.WriteLine("\nPDF printing completed.");
    }
}