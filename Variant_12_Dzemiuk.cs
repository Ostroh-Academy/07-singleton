using System;
using System.Collections.Generic;

public class AudioSystem
{
    private static AudioSystem _instance;
    private static readonly object _lock = new object();
    private List<string> playlist;

    private AudioSystem()
    {
        playlist = new List<string>();
    }

    public static AudioSystem GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new AudioSystem();
                }
            }
        }
        return _instance;
    }

    public void AddToPlaylist(string sound)
    {
        playlist.Add(sound);
        Console.WriteLine($"Added '{sound}' to the playlist.");
    }

    public void RemoveFromPlaylist(string sound)
    {
        if (playlist.Contains(sound))
        {
            playlist.Remove(sound);
            Console.WriteLine($"Removed '{sound}' from the playlist.");
        }
        else
        {
            Console.WriteLine($"Sound '{sound}' not found in the playlist.");
        }
    }

    public void ClearPlaylist()
    {
        playlist.Clear();
        Console.WriteLine("Playlist cleared.");
    }

    public void PlayPlaylist()
    {
        Console.WriteLine("Playing playlist:");
        foreach (string sound in playlist)
        {
            Console.WriteLine($"Playing sound: {sound}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        AudioSystem audioSystem = AudioSystem.GetInstance();

        audioSystem.AddToPlaylist("Music");
        audioSystem.AddToPlaylist("Podcast");
        audioSystem.AddToPlaylist("Audiobook");
        
        audioSystem.PlayPlaylist();
        
        audioSystem.ClearPlaylist();
    }
}
