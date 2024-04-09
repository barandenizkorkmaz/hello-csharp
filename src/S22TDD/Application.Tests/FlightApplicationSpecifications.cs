using FluentAssertions;
using Data;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Tests;

public class FlightApplicationSpecifications
{
    readonly Entities entities = new Entities(new DbContextOptionsBuilder<Entities>()
                                        .UseInMemoryDatabase("Flights")
                                        .Options);

    readonly BookingService bookingService;

    public FlightApplicationSpecifications()
    {
        bookingService = new BookingService(entities: entities);
    }

    [Theory]
    [InlineData("M@m.com", 2)]
    [InlineData("A@a.com", 2)]
    public void Books_flights(string email, int numberOfSeats)
    {
        var flight = new Flight(3);

        entities.Flights.Add(flight);
        
        var bookingService = new BookingService(entities: entities);
        
        bookingService.Book(new BookDto(
            flightId: flight.Id,
            email: email,
            numberOfSeats: numberOfSeats
            ));
        
        bookingService.FindBookings(flight.Id).Should().ContainEquivalentOf(new BookingRm(
            email: email,
            numberOfSeats: numberOfSeats));
    }

    [Theory]
    [InlineData(3)]
    [InlineData(10)]
    public void Cancels_booking(int initialCapacity)
    {
        // Given

        var flight = new Flight(initialCapacity);
        entities.Flights.Add(flight);

        var bookingService = new BookingService(entities: entities);

        bookingService.Book(new BookDto(flightId: flight.Id,
            email: "m@m.com",
            numberOfSeats: 2));

        // When
        bookingService.CancelBooking(
            new CancelBookingDto(
                flightId: flight.Id,
                email: "m@m.com",
                numberOfSeats: 2
                ));

        // Then
        bookingService.GetRemainingNumberOfSeatsFor(flight.Id)
            .Should().Be(initialCapacity);

    }
}