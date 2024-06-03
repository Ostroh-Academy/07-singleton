namespace _7.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Конструктор за замовчуванням
        public User() { }

        // Конструктор з параметрами
        public User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        // Метод для відображення інформації про користувача
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Email: {Email}";
        }
    }
}
