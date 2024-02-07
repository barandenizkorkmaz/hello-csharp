namespace S9Inheritance.Models.InterfaceDemo1;

class Ticket : IEquatable<Ticket>{
    public int DurationInHours {get; set;}

    public Ticket(int durationInHours){
        DurationInHours = durationInHours;
    }

    public bool Equals(Ticket other){
        return this.DurationInHours == other.DurationInHours;
    }
}