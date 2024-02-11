namespace S10Polymorphism.Demo1;

public class BMW : Car
{
    public string brand = "BMW";
    
    public string Model { get; set; }
    
    public BMW(int hp, string color, string model) : base(hp, color){
        this.Model = model;
    }
    
    public new void ShowDetails(){
        Console.WriteLine("BMW.ShowDetails: Brand " + brand + " HP: " + HP + " Color: " + Color);
    }
    
    public sealed override void Repair(){
        Console.WriteLine("BMW.Repair: BMW {0} was repaired", Model);
    }
}