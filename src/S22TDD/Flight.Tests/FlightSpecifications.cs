using Domain.Exceptions;
using Domain.Models;
using FluentAssertions;

namespace FlightApp.Tests;

public class FlightSpecifications
{
    [Fact]
    public void Booking_reduces_the_number_of_seats()
    {
        var flight = new Flight(seatCapacity: 3);

        flight.Book("test@test.com", 1);

        flight.RemainingNumberOfSeats.Should().Be(2);
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