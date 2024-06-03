using _7.Services;

namespace _7.Singletone
{
    public sealed class DocumentManagementSystem
    {
        private static readonly DocumentManagementSystem instance = new DocumentManagementSystem();

        // Сервіс для роботи з документами
        public DocumentService DocumentService { get; } = new DocumentService();

        // Сервіс для роботи з користувачами
        public UserService UserService { get; } = new UserService();

        // Приватний конструктор, щоб заборонити створення екземплярів ззовні
        private DocumentManagementSystem() { }

        // Публічний метод для доступу до єдиного екземпляра класу
        public static DocumentManagementSystem Instance => instance;
    }
}
