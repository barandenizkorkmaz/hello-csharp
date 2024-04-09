using Domain.Exceptions;

namespace Domain.Models;

public class Flight
{
    public Guid Id { get; }

    private List<Booking> bookingList = new();
    public IEnumerable<Booking> BookingList => bookingList;

    //public List<Booking> BookingList { get; set; } = new List<Booking>();

    public int RemainingNumberOfSeats { get; set; }

    [Obsolete("Needed by EF")]
    Flight() { }

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

    public void CancelBooking(string email, int numberOfSeats)
    {
        if(!bookingList.Any(booking => booking.Email == email))
        {
            throw new BookingNotFoundError();
        }
        RemainingNumberOfSeats += numberOfSeats;
    }
}
