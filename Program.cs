public sealed class WebsiteSingleton
{
    private static WebsiteSingleton instance;
    private static readonly object lockObject = new();

    private WebsiteSingleton() { }

    public static WebsiteSingleton GetInstance()
    {
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                    instance = new WebsiteSingleton();
            }
        }

        return instance;
    }

    public void PerformAction(string action, string username)
    {
        lock (lockObject)
        {
            Console.WriteLine($"User '{username}' is performing action: {action}");
            Thread.Sleep(1000);
            Console.WriteLine($"Action '{action}' performed successfully by user '{username}'");
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var website = WebsiteSingleton.GetInstance();

        var user1Thread = new Thread(() => UserAction(website, "User1"));
        var user2Thread = new Thread(() => UserAction(website, "User2"));

        user1Thread.Start();
        user2Thread.Start();

        user1Thread.Join();
        user2Thread.Join();

        Console.WriteLine("All users actions completed.");
    }

    static void UserAction(WebsiteSingleton website, string username) =>
        website.PerformAction("Performing some action", username);
}