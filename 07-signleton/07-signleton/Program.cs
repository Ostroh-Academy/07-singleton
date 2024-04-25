using _07_signleton;

Console.WriteLine("Choose a Singleton:");
Console.WriteLine("1. AudioSystem");
Console.WriteLine("2. Counter");

var choice = Console.ReadLine();

switch (choice)
{
    case "1":
        UseAudioSystem();
        break;
    case "2":
        UseCounter();
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}

return;

void UseAudioSystem()
{
    var audioSystem = AudioSystem.GetInstance();
    audioSystem?.PlaySound("background_music.mp3");
    audioSystem?.ToggleMute();
    audioSystem?.PlaySound("notification_sound.mp3");
}

void UseCounter()
{
    var counter = Counter.GetInstance();
    counter?.Increment();
    if (counter == null) 
        return;
    
    Console.WriteLine($"Count: {counter.GetCount()}");

    var anotherCounter = Counter.GetInstance();
    Console.WriteLine($"Is the same instance: {counter == anotherCounter}");

    anotherCounter?.Increment();
    Console.WriteLine($"Count: {counter.GetCount()}");
}