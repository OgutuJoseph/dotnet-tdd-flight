using Domain;
using FluentAssertions;

namespace FlightTest
{
	public class FlightSpecifications
	{
		[Fact]
		public void Booking_reduces_the_number_of_seats()
		{
			// Given
			var flight = new Flight(seatCapacity: 3);

			// When
			flight.Book("ojdev@mail.com", 1);

			// Then
			flight.RemainingNumberOfSeats.Should().Be(2);		
		}
	}
}