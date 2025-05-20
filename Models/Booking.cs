using System;

namespace BookingClone.Models
{
    public abstract class Booking
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        public abstract string GetDetails();
    }

    public class HotelBooking : Booking
    {
        public string HotelName { get; set; }

        public override string GetDetails()
        {
            return $"Hotel: {HotelName}, Price: {Price}";
        }
    }
}
