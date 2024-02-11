namespace S10Polymorphism.Demo1;

public class Audi : Car
{
    public string brand = "Audi";
    
    public string Model { get; set; }
    
    public Audi(int hp, string color, string model) : base(hp, color){
        this.Model = model;
    }
    
    public void ShowDetails(){
        Console.WriteLine("Audi.ShowDetails: Brand " + brand + " HP: " + HP + " Color: " + Color);
    }
    
    public new void Repair(){
        Console.WriteLine("Audi.Repair: Audi {0} was repaired", Model);
    }
}