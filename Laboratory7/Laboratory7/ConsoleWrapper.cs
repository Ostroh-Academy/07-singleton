namespace Laboratory7;

public sealed class ConsoleWrapper
{
    private static ConsoleWrapper? instance;
    
    private ConsoleWrapper() { }

    public static ConsoleWrapper Instance => 
        instance ??= new ConsoleWrapper();

    public void WriteLine(string message) =>
        Console.WriteLine(message);

    public void Write(string message) =>
        Console.Write(message);

    public string? ReadLine() =>
        Console.ReadLine();

    public ConsoleKeyInfo ReadKey() =>
        Console.ReadKey();

    public void Clear() =>
        Console.Clear();

    public void SetCursorPosition(int left, int top) =>
        Console.SetCursorPosition(left, top);

    public int CursorLeft
    {
        get => Console.CursorLeft;
        set => Console.CursorLeft = value;
    }

    public int CursorTop
    {
        get => Console.CursorTop;
        set => Console.CursorTop = value;
    }
}