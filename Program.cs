using System;
using System.Collections.Generic;

namespace OnlineShopping
{
    public class ShoppingCartSingleton
    {
        private static ShoppingCartSingleton _instance;
        private List<string> _items;

        private ShoppingCartSingleton()
        {
            _items = new List<string>();
        }
        public static ShoppingCartSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ShoppingCartSingleton();
            }
            return _instance;
        }
        public void AddItem(string item)
        {
            _items.Add(item);
            Console.WriteLine("Додано товар '{0}' до кошика.", item);
        }
        public void RemoveItem(string item)
        {
            if (_items.Remove(item))
            {
                Console.WriteLine("Видалено товар '{0}' з кошика.", item);
            }
            else
            {
                Console.WriteLine("Товар '{0}' не знайдено у кошику.", item);
            }
        }
        public void DisplayItems()
        {
            Console.WriteLine("Товари у кошику:");
            foreach (var item in _items)
            {
                Console.WriteLine("- " + item);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCartSingleton cart = ShoppingCartSingleton.GetInstance();
            cart.AddItem("Футболка");
            cart.AddItem("Штани");
            cart.AddItem("Кросівки");
            cart.DisplayItems();
            ShoppingCartSingleton anotherCart = ShoppingCartSingleton.GetInstance();
            Console.WriteLine("Обидва екземпляри вказують на один і той же кошик: " + (cart == anotherCart));
            cart.RemoveItem("Штани");
            cart.DisplayItems();
        }
    }
}
