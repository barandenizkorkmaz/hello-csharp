namespace S12EventsAndDelegates.Examples._5EventsAndMulticastDelegates;

public class Player
{
    public string PlayerName { get; set; }

    public Player(string name)
    {
        PlayerName = name;
        GameEventManager.OnGameStart += StartGame;
        GameEventManager.OnGameOver += GameOver; // GameEventManager.OnGameOver = GameOver; // Overriding a delegate is a BAD IDEA!
        // GameEventManager.TriggerGameStart(); // Calling it immediately is a BAD IDEA TOO!
    }

    private void StartGame()
    {
        Console.WriteLine($"Spawning player with ID {PlayerName}");
    }

    private void GameOver()
    {
        Console.WriteLine($"Removing player with ID {PlayerName}");
    }
}