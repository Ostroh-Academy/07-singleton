using System;
using System.Collections.Generic;

public class CartItem
{
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}

public sealed class ShoppingCart
{
    private static ShoppingCart instance;

    private ShoppingCart()
    {
        Items = new List<CartItem>();
    }

    public static ShoppingCart Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ShoppingCart();
            }
            return instance;
        }
    }

    public List<CartItem> Items { get; private set; }

    public void AddItem(string productName, double price, int quantity)
    {
        Items.Add(new CartItem { ProductName = productName, Price = price, Quantity = quantity });
    }

    public void RemoveItem(string productName)
    {
        CartItem itemToRemove = Items.Find(item => item.ProductName == productName);
        if (itemToRemove != null)
        {
            Items.Remove(itemToRemove);
        }
    }

    public void ClearCart()
    {
        Items.Clear();
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (CartItem item in Items)
        {
            total += item.Price * item.Quantity;
        }
        return total;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = ShoppingCart.Instance;

        cart.AddItem("Футболка", 25.99, 2);
        cart.AddItem("Джинси", 49.99, 1);

        cart.RemoveItem("Футболка");

        Console.WriteLine("Товари у кошику:");
        foreach (CartItem item in cart.Items)
        {
            Console.WriteLine($"{item.ProductName} - Ціна: {item.Price}, Кількість: {item.Quantity}");
        }
        Console.WriteLine($"Загальна сума: {cart.CalculateTotal()}");

        ShoppingCart anotherCart = ShoppingCart.Instance;
        if (cart == anotherCart)
        {
            Console.WriteLine("Заборонено створення нових екземплярів кошика.");
        }
    }
}
