using FluentAssertions;
using Data;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Tests;

public class FlightApplicationSpecifications
{
    [Theory]
    [InlineData("M@m.com", 2)]
    [InlineData("A@a.com", 2)]
    public void Books_flights(string email, int numberOfSeats)
    {
        var entities = new Entities(new DbContextOptionsBuilder<Entities>()
            .UseInMemoryDatabase("Flights")
            .Options);

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
}