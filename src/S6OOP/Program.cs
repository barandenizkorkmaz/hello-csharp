using S6OOP.Models;

namespace S6OOP;

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.Details();
        Car audi = new Car("Audi A4",250, "blue");
        audi.Drive();
        audi.Details();
        Car bmw = new Car("BMW M5", 350);
        bmw.Drive();
        bmw.Details();
            

        Console.WriteLine("press 1 to stop the car!");
        string userInput = Console.ReadLine();
        if(userInput == "1")
        {
            audi.Stop();
        }
        else
        {
            Console.WriteLine("Car drives indefinetely");
        }
        
        myCar.MaxSpeed = 180;
        Console.WriteLine("Maxspeed is " + myCar.MaxSpeed);
        
        Members member1 = new Members();
        member1.Introducing(true);
        Console.ReadKey(); // pause before termination
    }
    
}