namespace BookingClone.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string Airline { get; set; } = string.Empty;
        public string FlightNumber { get; set; } = string.Empty;
        public string DepartureCity { get; set; } = string.Empty;
        public string ArrivalCity { get; set; } = string.Empty;
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; } = "USD";
        public string Class { get; set; } = "Economy";
        public bool IsDirect { get; set; }
        public int AvailableSeats { get; set; }
    }
} 