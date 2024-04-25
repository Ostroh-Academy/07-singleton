namespace _07_signleton;

public class Counter
{
    private static Counter? _instance;
    private int _count;

    private Counter() => 
        _count = 0;

    public static Counter? GetInstance()
    {
        if (_instance == null) 
            _instance = new Counter();
        
        return _instance;
    }

    public int GetCount() => 
        _count;

    public void Increment() => 
        _count++;
}