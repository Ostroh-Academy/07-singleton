using System;

public class CorporateCalendar
{
    // Приватне статичне поле для зберігання єдиного екземпляра календаря
    private static CorporateCalendar instance;

    // Приватний конструктор для запобігання створення екземплярів через зовнішній код
    private CorporateCalendar()
    {
        // Ініціалізація календаря
        Console.WriteLine("Corporate calendar initialized.");
    }

    // Глобальна точка доступу до єдиного екземпляра календаря
    public static CorporateCalendar GetInstance()
    {
        // Перевірка, чи є вже створений екземпляр календаря
        if (instance == null)
        {
            // Якщо немає, то створюємо новий
            instance = new CorporateCalendar();
        }

        // Повертаємо єдиний екземпляр календаря
        return instance;
    }

    // Додаткові методи для управління подіями можна додавати тут
}

class Program
{
    static void Main(string[] args)
    {
        // Спроба отримати екземпляр календаря
        CorporateCalendar calendar1 = CorporateCalendar.GetInstance();

        // Знову намагаємось отримати екземпляр календаря
        CorporateCalendar calendar2 = CorporateCalendar.GetInstance();

        // Перевірка, чи calendar1 та calendar2 вказують на той самий об'єкт
        Console.WriteLine($"calendar1 і calendar2 є тим самим об'єктом: {calendar1 == calendar2}");
    }
}
