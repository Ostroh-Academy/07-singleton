using System;
using System.Collections.Generic;
using _7.Models;

namespace _7.Services
{
    public class UserService
    {
        private List<User> users = new List<User>();
        private int nextId = 1;

        // Метод для створення нового користувача
        public User CreateUser(string name, string email)
        {
            var user = new User
            {
                Id = nextId++,
                Name = name,
                Email = email
            };

            users.Add(user);
            return user;
        }

        // Метод для отримання списку всіх користувачів
        public List<User> GetAllUsers()
        {
            return new List<User>(users);
        }
    }
}
