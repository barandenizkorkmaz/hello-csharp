namespace Application
{
    public class BookingRm
    {
        public string Email { get; set; }
        public int NumberOfSeats { get; set; }

        public BookingRm(string email, int numberOfSeats)
        {
            Email = email;
            NumberOfSeats = numberOfSeats;
        }
    }
}
