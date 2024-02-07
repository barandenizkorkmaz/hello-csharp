namespace S9Inheritance.Models.Demo2;

public class Animal
{
    public string Name { get; set; }
    
    public int Age { get; set; }
    
    public bool IsHungry { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
        IsHungry = true;
    }
    
    // A virtual method for other classes to override
    public virtual void MakeSound()
    {
    }

    public virtual void Eat()
    {
        if (IsHungry)
        {
            Console.WriteLine($"{Name} is eating...");
            IsHungry = false;
        }
        else
        {
            Console.WriteLine($"{Name} is not hungry...");
        }
    }

    public virtual void Play()
    {
        Console.WriteLine($"{Name} is playing...");
    }

    public void GetHungry()
    {
        IsHungry = true;
        Console.WriteLine($"{Name} is getting hungry...");
    }
}