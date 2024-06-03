using System;
using _7.Singletone;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення інстанції системи документообігу (Singleton)
            var dms = DocumentManagementSystem.Instance;

            // Створення документів
            var doc1 = dms.DocumentService.CreateDocument("Document 1", "Content of Document 1");
            var doc2 = dms.DocumentService.CreateDocument("Document 2", "Content of Document 2");

            // Редагування документа
            var editedDoc = dms.DocumentService.EditDocument(doc1.Id, "Updated Content of Document 1");

            // Виведення всіх документів
            Console.WriteLine("All Documents:");
            foreach (var doc in dms.DocumentService.GetAllDocuments())
            {
                Console.WriteLine(doc);
            }

            // Створення користувача
            var user1 = dms.UserService.CreateUser("John Doe", "john.doe@example.com");

            // Виведення всіх користувачів
            Console.WriteLine("\nAll Users:");
            foreach (var user in dms.UserService.GetAllUsers())
            {
                Console.WriteLine(user);
            }
        }
    }
}
