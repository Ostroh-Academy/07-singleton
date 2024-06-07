using Laba7;

class Program
{
    static async Task Main(string[] args)
    {
        var tasks = new Task[]
        {
                Task.Run(() => PerformUserAction("User1", "Login")),
                Task.Run(() => PerformUserAction("User2", "Logout")),
                Task.Run(() => PerformUserAction("User3", "View Page")),
                Task.Run(() => PerformUserAction("User4", "Edit Profile")),
                Task.Run(() => PerformUserAction("User5", "Send Message"))
        };

        await Task.WhenAll(tasks);

        Console.WriteLine("All actions performed:");
        foreach (var action in SynchronizationService.Instance.GetActions())
        {
            Console.WriteLine(action);
        }
    }

    static void PerformUserAction(string user, string action)
    {
        var syncService = SynchronizationService.Instance;
        syncService.PerformAction(user, action);
    }
}