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

		[Fact]
		public void Avoids_overbooking()
		{
			// Given
			var flight = new Flight(seatCapacity: 3);

			// When
			var error = flight.Book("ojdev@mail.com", 4);

			// Then
			error.Should().BeOfType<OverbookingError>();
		}
	}
}