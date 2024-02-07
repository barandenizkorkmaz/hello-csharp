namespace S9Inheritance.Models.Demo1;

public class TV : Device
{

    public TV(bool isOn, string brand) : base(isOn, brand)
    {
        
    }

    public void WatchTV()
    {
        if (IsOn)
        {
            Console.WriteLine("Watching the TV...");
        }
        else
        {
            Console.WriteLine("TV is switched off, switch it on first...");
        }
    }
}