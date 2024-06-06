// Варіант 14: Створити Singleton для системи документообігу, що забезпечує
//централізований доступ до створення, редагування та розподілу документів в організації.
namespace Lab7;


public class Document
{
    public string Title { get; set; }
    public string Content { get; set; }

    public Document(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Content: {Content}");
    }
}


public sealed class DocumentManager
{
    
    private static DocumentManager? _instance = null;
    
    
    private static readonly object _lock = new object();


    private List<Document> _documents;

   
    private DocumentManager()
    {
        _documents = new List<Document>();
    }

    
    public static DocumentManager Instance
    {
        get
        {
            
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new DocumentManager();
                }
            }
            return _instance;
        }
    }

    
    public void CreateDocument(string title, string content)
    {
        var document = new Document(title, content);
        _documents.Add(document);
        Console.WriteLine($"Document '{title}' created successfully.");
    }

   
    public void EditDocument(string title, string newContent)
    {
        var document = _documents.Find(doc => doc.Title == title);
        if (document != null)
        {
            document.Content = newContent;
            Console.WriteLine($"Document '{title}' edited successfully.");
        }
        else
        {
            Console.WriteLine($"Document '{title}' not found.");
        }
    }

    // method to distribute a document (for simplicity, just displaying it
    // cuz nothing else was specified in the task)
    public void DistributeDocument(string title)
    {
        var document = _documents.Find(doc => doc.Title == title);
        if (document != null)
        {
            Console.WriteLine($"Distributing document '{title}':");
            document.Display();
        }
        else
        {
            Console.WriteLine($"Document '{title}' not found.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        DocumentManager documentManager = DocumentManager.Instance;

        
        documentManager.CreateDocument("Document1", "This is the content of Document1.");
        documentManager.CreateDocument("Document2", "This is the content of Document2.");

      
        documentManager.EditDocument("Document1", "This is the new content of Document1.");

       
        documentManager.DistributeDocument("Document1");
        documentManager.DistributeDocument("Document2");

        
        documentManager.DistributeDocument("Document3");
        
        
        DocumentManager anotherDocManager = DocumentManager.Instance;
        if (ReferenceEquals(documentManager, anotherDocManager))
        {
            Console.WriteLine("Both instances doc manager are the same.");
        }
        else
        {
            Console.WriteLine("Different instances exist.");
        }
    }
}

