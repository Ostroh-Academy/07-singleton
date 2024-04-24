namespace Laboratory7;

public class PdfDocument
{
    public string Title { get; set; }
    public string Content { get; set; }

    public PdfDocument(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public void Save(string path) =>
        File.WriteAllText(path, $"Title: {Title}\n\n{Content}");
}