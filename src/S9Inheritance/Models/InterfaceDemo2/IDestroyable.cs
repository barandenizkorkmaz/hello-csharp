namespace S9Inheritance.Models.InterfaceDemo2;

public interface IDestroyable
{
    // property to store the audio file of the destruction sound
    string DestructionSound { get; set; }

    void Destroy();
}