namespace Domain.Models;

public class Flight
{

    public int RemainingNumberOfSeats { get; set; }

    public Flight(int seatCapacity)
    {
        RemainingNumberOfSeats = seatCapacity;
    }

    public void Book(string email, int numberOfSeats)
    {
        if (numberOfSeats > RemainingNumberOfSeats)
        {
            throw new OverbookingError();
        }
        RemainingNumberOfSeats -= numberOfSeats;

    }
}
