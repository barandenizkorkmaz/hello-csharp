namespace Application
{
    public class BookDto
    {

        public Guid FlightId { get; set; }

        public string Email { get; set; }

        public int NumberOfSeats { get; set; }

        public BookDto(Guid flightId, string email, int numberOfSeats)
        {
            FlightId = flightId;
            Email = email;
            NumberOfSeats = numberOfSeats;
        }
    }
}
