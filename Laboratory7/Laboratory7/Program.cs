namespace Laboratory7;

internal static class Program
{
    private static void Main()
    {
        ConsoleWrapper console = ConsoleWrapper.Instance;

        console.WriteLine("Welcome to ConsoleWrapper!");
        console.WriteLine("Enter your name:");
        string? name = console.ReadLine();
        console.WriteLine($"Hello, {name}!");

        console.WriteLine("Press any key to continue...");
        console.ReadKey();

        console.Clear();

        console.WriteLine("This is ConsoleWrapper in action!");
        console.Write("Type something and press Enter: ");
        string? input = console.ReadLine();
        console.WriteLine($"You typed: {input}");

        console.WriteLine("\nPress any key to move the cursor...");
        console.ReadKey();
        
        console.Clear();
        console.WriteLine("Moving cursor...");

        // Demonstrating cursor movement
        console.SetCursorPosition(10, 5);
        console.WriteLine("Cursor moved to (10,5)");

        console.WriteLine("\nPress any key to exit...");
        console.ReadKey();
    }
}
