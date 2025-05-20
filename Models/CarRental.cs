namespace BookingClone.Models
{
    public class CarRental
    {
        public int Id { get; set; }
        public string CarModel { get; set; } = string.Empty;
        public string CarType { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public decimal PricePerDay { get; set; }
        public string Currency { get; set; } = "USD";
        public string ImageUrl { get; set; } = string.Empty;
        public List<string> Features { get; set; } = new List<string>();
        public string Transmission { get; set; } = "Automatic";
        public string FuelType { get; set; } = "Petrol";
        public int Seats { get; set; }
        public int Bags { get; set; }
        public bool Available { get; set; }
    }
} 