namespace ConsoleApp2;

public sealed class Singleton
{
    private Singleton()
    {
    }

    private static Singleton? _instance;

    public static Singleton GetInstance() => _instance ??= new Singleton();

    // Finally, any singleton should define some business logic, which can
    // be executed on its instance.
    public void SomeBusinessLogic()
    {
        // ...
    }
}