using System;

namespace _7.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Конструктор за замовчуванням
        public Document() { }

        // Конструктор з параметрами
        public Document(int id, string title, string content, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Title = title;
            Content = content;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        // Метод для оновлення вмісту документа
        public void UpdateContent(string newContent)
        {
            Content = newContent;
            UpdatedAt = DateTime.Now;
        }

        // Метод для відображення інформації про документ
        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Content: {Content}, CreatedAt: {CreatedAt}, UpdatedAt: {UpdatedAt}";
        }
    }
}
