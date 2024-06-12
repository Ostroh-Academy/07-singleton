sealed class ConfigurationManager
{
    private static ConfigurationManager instance;

    private Dictionary<string, string> configData;

    private ConfigurationManager()
    {

        configData = new Dictionary<string, string>();

        configData.Add("DatabaseConnectionString", "your_database_connection_string_here");
        configData.Add("APIKey", "your_api_key_here");

    }

    public static ConfigurationManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ConfigurationManager();
            }
            return instance;
        }
    }

    public string GetConfigValue(string key)
    {
        if (configData.ContainsKey(key))
        {
            return configData[key];
        }
        else
        {
            throw new KeyNotFoundException("Configuration key not found.");
        }
    }
}