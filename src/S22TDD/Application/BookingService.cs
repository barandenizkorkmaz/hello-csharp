using Data;

namespace Application
{
    public class BookingService
    {
        public Entities Entities { get; set; }

        public BookingService(Entities entities)
        {
            Entities = entities;
        }

        public void Book(BookDto bookDto)
        {
            var flight = Entities.Flights.Find(bookDto.FlightId);
            flight.Book(bookDto.Email, bookDto.NumberOfSeats);
            Entities.SaveChanges();

        }

        public IEnumerable<BookingRm> FindBookings(Guid id)
        {
            return Entities.Flights
                .Find(id)
                .BookingList
                .Select(booking => new BookingRm(
                    booking.Email,
                    booking.NumberOfSeats)
                );
        }
    }
}
