using Domain.Exceptions;

namespace Domain.Models;

public class Flight
{
    public List<Booking> BookingList { get; set; } = new List<Booking>();

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
        BookingList.Add(new Booking(email, numberOfSeats));
    }
}
