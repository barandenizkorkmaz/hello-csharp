namespace S9Inheritance.Models.Demo1;

public class Device
{
    public bool IsOn { get; set; }
    
    public string Brand { get; set; }
    
    public Device(bool isOn, string brand)
    {
        IsOn = isOn;
        Brand = brand;
    }

    public void SwitchOn()
    {
        IsOn = true;
    }

    public void SwitchOff()
    {
        IsOn = false;
    }
}