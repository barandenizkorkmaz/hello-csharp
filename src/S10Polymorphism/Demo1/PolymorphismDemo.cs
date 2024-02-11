namespace S10Polymorphism.Demo1;

public class PolymorphismDemo
{
    public static void PolymorphismDemoMain()
    {
        /*
         * virtual and override Keywords 
         */
        
        Console.WriteLine("Hello, S10!");
        
        var cars = new List<Car>
        {
            new Car(150, "black"),
            new Audi(200, "blue", "A4"),
            new BMW(250, "red", "M3")
        };
        
        foreach(var car in cars){ // var deduces the type of variable (like auto in C++)
            car.Repair(); // Uses Car methods if Repair method is not virtual and overridden by other child classes
        }
        
        foreach(var car in cars){ // var deduces the type of variable (like auto in C++)
            car.ShowDetails(); // Uses Car methods if ShowDetails method is not virtual and overridden by other child classes
        }
        
        Console.WriteLine("Please enter a key to continue...");
        Console.ReadKey();
        
        /*
         * new Keyword
         */
        
        Car bmwZ3 = new BMW(200, "black", "Z3");
        Car audiA3 = new Audi(100, "green", "A3");
        bmwZ3.ShowDetails();
        audiA3.ShowDetails();
        
        BMW bmwM5 = new BMW(330, "white", "M5");
        bmwM5.ShowDetails(); // Uses the ShowDetails of BMW Class since we use the keyword 'new'
        
        Car bmwM5B = (Car) bmwM5; // Uses the ShowDetails method of Base Class
        bmwM5B.ShowDetails();
        
        Console.WriteLine("Please enter a key to continue...");
        Console.ReadKey();
        
        /*
         * sealed Keyword
         */
        M3 m3 = new M3(400, "red", "M3");
        BMW BMWM3 = (BMW)m3;
        
        m3.Repair();
        BMWM3.Repair();
        
        Console.WriteLine("Please enter a key to continue...");
        Console.ReadKey();
        
        /*
         * Has-A Relationship
         */
        bmwZ3.SetCarIdInfo(1234, "Deniz");
        audiA3.SetCarIdInfo(7890, "Nat");
        
        bmwZ3.PrintCarIdInfo();
        audiA3.PrintCarIdInfo();
        
        Console.WriteLine("Please enter a key to continue...");
        Console.ReadKey();
    }
}