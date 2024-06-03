using _7.Models;

namespace _7.Services
{
    public class DocumentService
    {
        private List<Document> documents = new List<Document>();
        private int nextId = 1;

        // Метод для створення нового документа
        public Document CreateDocument(string title, string content)
        {
            var document = new Document
            {
                Id = nextId++,
                Title = title,
                Content = content,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            documents.Add(document);
            return document;
        }

        // Метод для редагування існуючого документа за його ідентифікатором
        public Document EditDocument(int documentId, string newContent)
        {
            var document = documents.Find(doc => doc.Id == documentId);

            if (document != null)
            {
                document.Content = newContent;
                document.UpdatedAt = DateTime.Now;
            }

            return document;
        }

        // Метод для отримання списку всіх документів
        public List<Document> GetAllDocuments()
        {
            return new List<Document>(documents);
        }
    }
}
