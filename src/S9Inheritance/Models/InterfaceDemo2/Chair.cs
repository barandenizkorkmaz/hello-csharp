namespace S9Inheritance.Models.InterfaceDemo2;

public class Chair : Furniture, IDestroyable
{
    public Chair(string color, string material) : base(color, material)
    {
        DestructionSound = "ChairDestructionSound.mp3";
    }

    public string DestructionSound { get; set; }
    public void Destroy()
    {
        Console.WriteLine($"The {Color} chair was destroyed.");
        Console.WriteLine($"Playing destruction sound {DestructionSound}");
        Console.WriteLine("Spawning chair parts");
    }
}