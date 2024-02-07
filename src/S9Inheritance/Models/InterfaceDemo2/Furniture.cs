namespace S9Inheritance.Models.InterfaceDemo2;

// base class for furnitures
public class Furniture
{
    public string Color { get; set; }
    public string Material { get; set; }

    public Furniture()
    {
        Color = "White";
        Material = "Wood";
    }

    public Furniture(string color, string material)
    {
        Color = color;
        Material = material;
    }
    
    
}