using System;
using System.Collections.Generic;

public class DigitalLibrary
{
    private static DigitalLibrary _instance;
    private List<string> _books;

    private DigitalLibrary()
    {
        _books = new List<string>();
    }

    public static DigitalLibrary Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new DigitalLibrary();
            }
            return _instance;
        }
    }

    public void AddBook(string bookTitle)
    {
        _books.Add(bookTitle);
        Console.WriteLine($"Book '{bookTitle}' added to the library.");
    }

    public void RemoveBook(string bookTitle)
    {
        if (_books.Remove(bookTitle))
        {
            Console.WriteLine($"Book '{bookTitle}' removed from the library.");
        }
        else
        {
            Console.WriteLine($"Book '{bookTitle}' not found in the library.");
        }
    }

    public void DisplayLibrary()
    {
        Console.WriteLine("Books in the library:");
        foreach (var book in _books)
        {
            Console.WriteLine(book);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        DigitalLibrary library = DigitalLibrary.Instance;

        library.AddBook("Book 1");
        library.AddBook("Book 2");
        library.AddBook("Book 3");

        library.DisplayLibrary();

        DigitalLibrary anotherLibrary = DigitalLibrary.Instance;

        if (library == anotherLibrary)
        {
            Console.WriteLine("Both instances are the same.");
        }
        else
        {
            Console.WriteLine("Instances are different.");
        }
    }
}
