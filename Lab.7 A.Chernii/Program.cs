using System.Runtime;

public class UserSettingsManager
{
    private static UserSettingsManager instance;
    private Dictionary<string, object> settings = new Dictionary<string, object>();

    private UserSettingsManager()
    {
        settings.Add("theme", "light");
        settings.Add("language", "en");
        settings.Add("notifications", true);
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

    public object GetSetting(string key)
    {
        if (settings.ContainsKey(key))
        {
            return settings[key];
        }
        return null;
    }

    public void SetSetting(string key, object value)
    {
        if (settings.ContainsKey(key))
        {
            settings[key] = value;
        }
        else
        {
            settings.Add(key, value);
        }
    }
}
