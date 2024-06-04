using example_7;

class Program
{
    static void Main(string[] args)
    {
        // Отримання єдиного екземпляру класу Settings
        Settings settings = Settings.GetInstance();

        // Перевірка налаштувань
        Console.WriteLine("Example Setting: " + settings.ExampleSetting);

        // Можна змінити налаштування через будь-який екземпляр класу Settings
        settings.ExampleSetting = "New Value";

        // Отримання іншого екземпляру класу Settings
        Settings anotherSettings = Settings.GetInstance();

        // Перевірка, чи збереглися змінені налаштування
        Console.WriteLine("Example Setting after modification: " + anotherSettings.ExampleSetting);
    }
}