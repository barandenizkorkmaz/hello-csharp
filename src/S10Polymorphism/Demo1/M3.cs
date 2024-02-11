namespace S10Polymorphism.Demo1;

public sealed class M3 : BMW // Sealed class cannot be further inherited
{
    public M3(int hp, string color, string model) : base(hp, color, model)
    {
        
    }

    public new void Repair()
    {
        Console.WriteLine("M3.Repair: M3 was repaired");
    }
}