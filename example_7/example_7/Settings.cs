using System;
namespace example_7
{
    public class Settings
    {
        private static Settings instance;
        private static object lockObject = new object();

        // Приклад налаштування
        public string ExampleSetting { get; set; }

        // Приватний конструктор
        private Settings()
        {
            // Ініціалізація прикладових налаштувань
            ExampleSetting = "Default Value";
        }

        // Статичний метод для отримання єдиного екземпляру класу
        public static Settings GetInstance()
        {
            // Перевірка, чи екземпляр вже існує
            if (instance == null)
            {
                // Забезпечення потокобезпеки за допомогою lock
                lock (lockObject)
                {
                    // Перевірка ще раз, щоб уникнути створення дублюючих екземплярів у многопотоковому середовищі
                    if (instance == null)
                    {
                        instance = new Settings();
                    }
                }
            }
            return instance;
        }
    }
}

