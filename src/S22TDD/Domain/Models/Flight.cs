using Domain.Exceptions;

namespace Domain.Models;

public class Flight
{
    private List<Booking> bookingList = new();
    public IEnumerable<Booking> BookingList => bookingList;

    //public List<Booking> BookingList { get; set; } = new List<Booking>();

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
        bookingList.Add(new Booking(email, numberOfSeats));
    }
}
