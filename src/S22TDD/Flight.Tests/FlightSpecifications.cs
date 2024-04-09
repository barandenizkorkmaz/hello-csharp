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
}