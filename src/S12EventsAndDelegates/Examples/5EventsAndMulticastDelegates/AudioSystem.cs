namespace S12EventsAndDelegates.Examples._5EventsAndMulticastDelegates;

public class AudioSystem
{
    
    // Simple Constructor
    public AudioSystem()
    {
        // subscribe to the OnGameStart and OnGameOver events
        GameEventManager.OnGameStart += StartGame; // multi-cast delegates. Observe here that we use += instead of =.
        GameEventManager.OnGameOver += GameOver; // multi-cast delegates
    }
    
    private void StartGame()
    {
        Console.WriteLine("Audio system started...");
        Console.WriteLine("Playing audio...");
    }

    private void GameOver()
    {
        Console.WriteLine("Audio system stopped...");
    }
}