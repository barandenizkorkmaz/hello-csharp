namespace S12EventsAndDelegates.Examples._5EventsAndMulticastDelegates;

public class EventsAndMulticastDelegates
{
    public static void EventsAndMulticastDelegatesMain()
    {
        /*
        
        Naive Solution
         
        AudioSystem audioSystem = new AudioSystem();

        RenderingEngine renderingEngine = new RenderingEngine();

        Player player1 = new Player("Beko");
        Player player2 = new Player("Baran");
        Player player3 = new Player("Nat");
        
        // Start the audio system and the rendering engine
        audioSystem.StartGame();
        renderingEngine.StartGame();
        
        // spawn the players
        player1.StartGame();
        player2.StartGame();
        player3.StartGame();
        
        Console.WriteLine("Game is running... Press any key to end the game...");
        Console.ReadKey();
        
        // remove the players
        player1.GameOver();
        player2.GameOver();
        player3.GameOver();
        
        // Shut down the audio system and the rendering engine
        audioSystem.GameOver();
        renderingEngine.GameOver();
        */
        
        // Better solution using events and multicast delegates
        AudioSystem audioSystem = new AudioSystem();

        RenderingEngine renderingEngine = new RenderingEngine();

        Player player1 = new Player("Beko");
        Player player2 = new Player("Baran");
        Player player3 = new Player("Nat");
        
        GameEventManager.TriggerGameStart();
        
        Console.WriteLine("Game is running... Press any key to end the game...");
        Console.ReadKey();
        
        GameEventManager.TriggerGameOver();
        
        /*
            Using multicast delegates you can simply create a new player etc and it will automatically subscribe to our events.
        */
        
        /*
         * Instead of subscribing to an event using += one can mistakenly use = meaning overriding the event.
         * Or someone might accidentally call a delegate while subscribing.
         * There is a special type of delegate called 'Event' that prevents such mistakes.
         *
         * Events vs Delegates:
         * 1. Events are forced to behave like a list.
         *  += / -= are okay
         *  = is not okay
         *
         * 2. Delegates allow a direct assignment.
         *  myDelegate = myMethod
         *
         * 3. Events cannot be triggered from outside the class that defines them.
         */
        
    }
}