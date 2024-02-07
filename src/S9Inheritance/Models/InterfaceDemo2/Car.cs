namespace S9Inheritance.Models.InterfaceDemo2;

public class Car : Vehicle, IDestroyable
{
    public Car(float speed, string color) : base(speed, color)
    {
        DestructionSound = "CarExplosionSound.mp3";
        DestroyablesNearby = new List<IDestroyable>();
    }

    public string DestructionSound { get; set; }
    
    /*
     * Creating a new property to store the destroyable objects nearby
     * when a car gets destroyed it should also destroy the nearby objects
     */
    public List<IDestroyable> DestroyablesNearby;
    
    public void Destroy()
    {
        Console.WriteLine($"Playing destruction sound {DestructionSound}");
        Console.WriteLine("Create fire");
        foreach (IDestroyable destroyable in DestroyablesNearby)
        {
            destroyable.Destroy();
        }
    }
}