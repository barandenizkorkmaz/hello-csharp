namespace S12EventsAndDelegates.Examples._5EventsAndMulticastDelegates;

public class RenderingEngine
{
    // Simple Constructor
    public RenderingEngine()
    {
        // subscribe to the OnGameStart and OnGameOver events
        GameEventManager.OnGameStart += StartGame; // multi-cast delegates. Observe here that we use += instead of =.
        GameEventManager.OnGameOver += GameOver; // multi-cast delegates
    }
    
    private void StartGame()
    {
        Console.WriteLine("Rendering engine started...");
        Console.WriteLine("Drawing visuals...");
    }

    private void GameOver()
    {
        Console.WriteLine("Rendering engine stopped...");
    }
}