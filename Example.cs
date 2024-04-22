class Singleton 
{ 
    private Singleton() { }
    private static Singleton _instance;
    
    private static readonly object _lock = new object();
    
    public static Singleton GetInstance(string value)
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                    _instance.Value = value;
                }
            }
        }
        return _instance;
    }

    public string Value { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            "RESULT:\n"
            );
            
        Thread process1 = new Thread(() =>
        {
            TestSingleton("FOO");
        });
        Thread process2 = new Thread(() =>
        {
            TestSingleton("BAR");
        });
            
        process1.Start();
        process2.Start();
            
        process1.Join();
        process2.Join();
    }
        
    public static void TestSingleton(string value)
    {
        Singleton singleton = Singleton.GetInstance(value);
        Console.WriteLine(singleton.Value);
    } 
}