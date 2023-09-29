namespace Domain
{
	public class Flight
	{
		public int RemainingNumberOfSeats { get; set; }

		public Flight(int seatCapacity)
		{
			RemainingNumberOfSeats = seatCapacity;
		}

		//public void Book(string passengerEmail, int numberOfSeats)
		//{
		//	// ** Should prevent overbooking of flight
		//	// ** Should remember the booking
		//	RemainingNumberOfSeats -= numberOfSeats;
		//}

		// change from return type from void to object 
		public object? Book(string passengerEmail, int numberOfSeats)
		{
			if (numberOfSeats > this.RemainingNumberOfSeats)
				return new OverbookingError();

			RemainingNumberOfSeats -= numberOfSeats;
			return null;
		}
	}
}