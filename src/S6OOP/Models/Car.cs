namespace S6OOP.Models;

internal class Car
{
    // Member variables
    private string _name; // private field typically used for storing data.
    private int _hp;
    private string _color;
    
    // Auto-implemented property
    public int MaxSpeed { get; set; } // read-write possible
    
    /*
     * read-only / write-only properties
     * public int MaxSpeed { get; } // read-only property
     * public int MaxSpeed { set; } // write-only property
     */
    
    
    // Public Property
    public string Name
    {
        get { return _name; } // get accessor
        set { _name = value; } // set accessor
    }

    // Default Constructor
    public Car()
    {
        _name = "Car";
        _hp = 0;
        _color = "red";
           
    }
    // Partial Specification Constructor
    public Car(string name, int hp = 0)
    {
        _name = name;
        Console.WriteLine(name + " was created");
        _hp = hp;
        _color="red";
            
    }
    // Full Specification Constructor
    public Car(string name, int hp, string color)
    {
        _name = name;
        Console.WriteLine(name + " was created");
        _hp = hp;
        _color = color;
    }

       

    // Member Method
    public void Drive() { 
        Console.WriteLine(_name + " is driving"); 
    }

    // Member Methods
    public void Stop()
    {
        Console.WriteLine(_name + " stopped!");
    }

    public void Details()
    {
        Console.WriteLine("The "+_color +" car "+_name
                          + " has "+ _hp + " hp");
    }
}