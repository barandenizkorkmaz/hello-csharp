namespace Application
{
    public class CancelBookingDto
    {
        public Guid FlightId { get; set; }

        public string Email { get; set; }

        public int NumberOfSeats { get; set; }

        public CancelBookingDto(Guid flightId, string email, int numberOfSeats)
        {
            FlightId = flightId;
            Email = email;
            NumberOfSeats = numberOfSeats;
        }

    }
}
