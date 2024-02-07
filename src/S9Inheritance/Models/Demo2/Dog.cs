namespace S9Inheritance.Models.Demo2;

public class Dog : Animal
{
    public bool IsHappy { get; set; }
    
    public Dog(string name, int age) : base(name, age)
    {
        // all dogs are happy by default
        IsHappy = true;
    }

    public override void Eat()
    {
        base.Eat();
        Console.WriteLine("Dog is full now...");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Wuuuuuf!");
    }

    public override void Play()
    {
        if (IsHappy)
        {
            base.Play();
        }
    }
}