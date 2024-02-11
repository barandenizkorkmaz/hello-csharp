namespace S10Polymorphism.DemoAbstractClasses;

class Sphere : Shape
{
    
    public double Radius { get; set; }
    
    public Sphere(double radius)
    {
        Name = "Sphere";
        Radius = radius;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Sphere Data\tRadius: {Radius}\tVolume: {Volume()}");
    }

    public override double Volume()
    {
        return (double)4/3 * Math.PI * Math.Pow(Radius, 3);
    }
    
}