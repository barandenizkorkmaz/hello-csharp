namespace S10Polymorphism.DemoAbstractClasses;

abstract class Shape
{
    public string Name { get; set; }

    public virtual void GetInfo()
    {
        Console.WriteLine($"This is a {Name}");
    }

    public abstract double Volume(); // A class that inherits abstract class must implement this method.
}