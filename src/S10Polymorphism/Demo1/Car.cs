namespace S10Polymorphism.Demo1;

public class Car
{
    public int HP{ get; set; }
    public string Color { get; set; }

    protected CarIDInfo carIdInfo = new CarIDInfo();

    public void SetCarIdInfo(int idNum, string owner)
    {
        carIdInfo.IDNum = idNum;
        carIdInfo.Owner = owner;
    }

    public CarIDInfo GetCarIDInfo()
    {
        return carIdInfo;
    }

    public void PrintCarIdInfo()
    {
        Console.WriteLine($"Car.PrintCarIdInfo: The car has id of {carIdInfo.IDNum} and is owned by {carIdInfo.Owner}");
    }
    
    public Car(int hp, string color){
        this.HP = hp;
        this.Color = color;
    }
    
    public void ShowDetails(){
        Console.WriteLine("Car.ShowDetails(): HP: " + HP + " Color: " + Color);
    }
    
    public virtual void Repair(){
        Console.WriteLine("Car.Repair: Car was repaired");
    }
    
    
}