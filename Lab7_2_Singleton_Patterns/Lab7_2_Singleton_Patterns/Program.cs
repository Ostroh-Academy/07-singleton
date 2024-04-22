ConfigurationManager configManager = ConfigurationManager.Instance;

string databaseConnectionString = configManager.GetConfigValue("DatabaseConnectionString");
Console.WriteLine("Database Connection String: " + databaseConnectionString);

string apiKey = configManager.GetConfigValue("APIKey");
Console.WriteLine("API Key: " + apiKey);
