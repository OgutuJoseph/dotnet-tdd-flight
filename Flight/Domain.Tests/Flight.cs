namespace Domain.Tests
{
	public class Flight
	{
        public Flight(int seatCapacity)
		{ 
			RemainingNumberOfSeats = seatCapacity;
		}

		public void Book(string v1, int v2)
		{
			RemainingNumberOfSeats -= v2;
		}

		public int RemainingNumberOfSeats { get; set; }
	}
}