namespace S9Inheritance.Models.Demo1;

public class Radio : Device
{

    public Radio(bool isOn, string brand) : base(isOn, brand)
    {
        
    }

    public void ListenRadio()
    {
        if (IsOn)
        {
            Console.WriteLine("Listening to the radio...");
        }
        else
        {
            Console.WriteLine("Radio is switched off, switch it on first...");
        }
    }
}