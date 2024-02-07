namespace S9Inheritance.Models.IEnumerableAndIEnumeratorDemo;

public class Dog {
    public string Name { get; set; }
    public bool IsNaughtyDog{ get; set; }
        
    public Dog(string name, bool isNaughtyDog)
    {
        this.Name = name;
        this.IsNaughtyDog = isNaughtyDog;
    }
        
    public void GiveTreat(int numberofTreats){
        Console.WriteLine("Dog {0} said wuoff {1} times!", Name, numberofTreats);
    }
}