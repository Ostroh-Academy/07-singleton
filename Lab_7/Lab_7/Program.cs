using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        UserSettingsManager.Instance.SetSetting("language", "english");
        UserSettingsManager.Instance.SetSetting("theme", "dark");

        string language = UserSettingsManager.Instance.GetSetting("language");
        string theme = UserSettingsManager.Instance.GetSetting("theme");

        Console.WriteLine("Selected language: " + language);
        Console.WriteLine("Selected theme: " + theme);
    }
}

public class UserSettingsManager
{

    private static UserSettingsManager instance;

    private Dictionary<string, string> settings;

    private UserSettingsManager()
    {
        settings = new Dictionary<string, string>();
    }
    public static UserSettingsManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new UserSettingsManager();
            }
            return instance;
        }
    }

    public void SetSetting(string key, string value)
    {
        settings[key] = value;
    }

    public string GetSetting(string key)
    {
        if (settings.ContainsKey(key))
        {
            return settings[key];
        }
        else
        {
            return null;
        }
    }
}
