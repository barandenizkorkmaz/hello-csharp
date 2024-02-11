namespace S10Polymorphism.DemoAbstractClasses;

class Cube : Shape
{
    
    public double Length { get; set; }

    public Cube(double length)
    {
        Name = "Cube";
        Length = length;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Cube Data\tLength: {Length}\tVolume: {Volume()}");
    }

    public override double Volume()
    {
        return Math.Pow(Length, 3);
    }
}