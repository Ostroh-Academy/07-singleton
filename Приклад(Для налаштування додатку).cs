/*ми маємо клас Settings, який зберігає налаштування додатку, і ми хочемо, 
щоб у нас був лише один об'єкт цього класу, який містить всі налаштування*/

using System;

public class Settings
{
    private static Settings _instance;
    private string theme;

    private Settings()
    {
        // Ініціалізація налаштувань за замовчуванням
        theme = "light";
    }

    public static Settings GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Settings();
        }
        return _instance;
    }

    public void SetTheme(string newTheme)
    {
        theme = newTheme;
    }

    public string GetTheme()
    {
        return theme;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Отримання єдиного екземпляру класу Settings
        Settings appSettings = Settings.GetInstance();

        // Встановлення теми додатку
        appSettings.SetTheme("dark");

        // Отримання теми додатку
        string currentTheme = appSettings.GetTheme();
        Console.WriteLine("Поточна тема: " + currentTheme); // Виведе "dark"

        // Спроба отримати ще один екземпляр класу Settings
        Settings anotherSettings = Settings.GetInstance();

        // Перевірка, чи це той самий екземпляр
        if (appSettings == anotherSettings)
        {
            Console.WriteLine("Це той самий екземпляр класу Settings.");
        }
        else
        {
            Console.WriteLine("Це різні екземпляри класу Settings.");
        }
    }
}