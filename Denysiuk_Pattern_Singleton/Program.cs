using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denysiuk_Pattern_Singleton
{
    using System;

    namespace ConfigurationManagerExample
    {
        class Program
        {
            static void Main(string[] args)
            {
                bool showMenu = true;
                while (showMenu)
                {
                    showMenu = MainMenu();
                }
            }

            private static bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Configuration Manager Example");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1. View Configuration Data");
                Console.WriteLine("2. Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        ViewConfigurationData();
                        return true;
                    case "2":
                        return false;
                    default:
                        return true;
                }
            }

            private static void ViewConfigurationData()
            {
                ConfigurationData configData = ConfigurationManager.Instance.GetConfigData();

                Console.Clear();
                Console.WriteLine("Configuration Data");
                Console.WriteLine("------------------");
                Console.WriteLine($"Database Connection String: {configData.DatabaseConnectionString}");
                Console.WriteLine($"Port: {configData.Port}");
                Console.WriteLine($"API Key: {configData.ApiKey}");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
