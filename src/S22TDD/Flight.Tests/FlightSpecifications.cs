using Domain.Exceptions;
using Domain.Models;
using FluentAssertions;

namespace FlightApp.Tests;

public class FlightSpecifications
{
    [Theory]
    [InlineData(3,1,2)]
    [InlineData(6, 3, 3)]
    [InlineData(10, 4, 6)]
    [InlineData(12, 8, 4)]
    public void Booking_reduces_the_number_of_seats(int seatCapacity, int numberOfSeats, int remainingNumberOfSeats)
    {
        var flight = new Flight(seatCapacity: seatCapacity);

        flight.Book("test@test.com", numberOfSeats);

        flight.RemainingNumberOfSeats.Should().Be(remainingNumberOfSeats);
    }

    [Fact]
    public void Avoids_overbooking()
    {
        // Given: Preconditions
        var flight = new Flight(seatCapacity: 3);

        // When: What triggers the action
        Action action = () => flight.Book("test@test.com", 10);

        // Then
        action.Should().Throw<OverbookingError>();
    }

    [Fact]
    public void Books_flights_successfully()
    {
        var flight = new Flight(seatCapacity: 3);
        Action action = () => flight.Book("test@test.com", 1);
        action.Should().NotThrow();
    }

    [Fact]
    public void Remembers_bookings()
    {
        var flight = new Flight(seatCapacity: 150);
        flight.Book(email:"a@b.com", numberOfSeats: 4);
        flight.BookingList.Should().ContainEquivalentOf(new Booking("a@b.com", 4));
    }

    [Theory]
    [InlineData(3,1,1,3)]
    [InlineData(4,2,2,4)]
    [InlineData(7, 5, 4, 6)]
    public void Canceling_bookings_frees_up_the_seats(
        int initialCapacity,
        int numberOfSeatsToBook,
        int numberOfSeatsToCancel,
        int remaningNumberOfSeats)
    {
        // given
        var flight = new Flight(initialCapacity);
        flight.Book(email: "a@b.com", numberOfSeats: numberOfSeatsToBook);
        
        // when
        flight.CancelBooking(email: "a@b.com", numberOfSeats: numberOfSeatsToCancel);

        // then
        flight.RemainingNumberOfSeats.Should().Be(remaningNumberOfSeats);
    }

    [Fact]
    public void Doesnt_cancel_bookings_for_passengers_who_have_not_booked()
    {
        var flight = new Flight(3);
        Action action = () => flight.CancelBooking(email: "a@b.com", numberOfSeats: 2);
        action.Should().Throw<BookingNotFoundError>();
    }

    [Fact]
    public void Doesnt_throw_error_when_successfully_cancels_a_booking()
    {
        var flight = new Flight(3);
        flight.Book(email: "a@b.com", numberOfSeats: 1);
        Action action = () => flight.CancelBooking(email: "a@b.com", numberOfSeats: 1);
        action.Should().NotThrow();
    }

}