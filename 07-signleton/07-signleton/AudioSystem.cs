namespace _07_signleton;

public class AudioSystem
{
    private static AudioSystem? _instance;

    private bool _isMuted;

    private AudioSystem() => 
        _isMuted = false;

    public static AudioSystem? GetInstance()
    {
        if (_instance == null)
            _instance = new AudioSystem();
        
        return _instance;
    }

    public void ToggleMute()
    {
        _isMuted = !_isMuted;
        Console.WriteLine(_isMuted ? "Audio muted" : "Audio unmuted");
    }

    public void PlaySound(string sound) => 
        Console.WriteLine(!_isMuted ? $"Playing sound: {sound}" : "Audio is muted. Cannot play sound.");
}