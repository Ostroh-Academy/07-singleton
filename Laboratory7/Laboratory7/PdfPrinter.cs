namespace Laboratory7;

public sealed class PdfPrinter
{
    private static PdfPrinter? _instance;

    private PdfPrinter() { }

    public static PdfPrinter Instance => 
        _instance ??= new PdfPrinter();

    public void PrintDocument(string title, string content)
    {
        PdfDocument document = new PdfDocument(title, content);
        string fileName = $"{title.Replace(" ", "_")}.pdf";
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);
        document.Save(path);
        Console.WriteLine($"Document '{title}' printed to '{path}'.");
    }
}