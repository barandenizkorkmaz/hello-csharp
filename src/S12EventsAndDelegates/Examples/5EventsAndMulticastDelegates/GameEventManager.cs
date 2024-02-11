namespace S12EventsAndDelegates.Examples._5EventsAndMulticastDelegates;

public class GameEventManager
{
    // A new delegate type GameEvent
    public delegate void GameEvent();
    
    // Create two delegate variables called OnGameStart and OnGameOver
    public static event GameEvent OnGameStart, OnGameOver; // using event keyword would convert these delegates into events
    
    /*
     * Declaring a delegate as event does two things
     * 1. You cannot override an event using = instead of +=.
     * 2. The event can only be called in the class where it was instantiated.
     */
    
    // A static method to trigger OnGameStart
    public static void TriggerGameStart()
    {
        // check if OnGameStart event is not empty meaning that there are methods that already subscribed to it
        if(OnGameStart != null)
        {
            // Call the OnGameStart that will trigger all the methods that subscribed to this event
            OnGameStart();
        }
    }
    
    public static void TriggerGameOver()
    {
        // check if OnGameOver event is not empty meaning that there are methods that already subscribed to it
        if(OnGameOver != null)
        {
            // Call the OnGameOver that will trigger all the methods that subscribed to this event
            OnGameOver();
        }
    }
}