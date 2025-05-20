using System;

namespace BookingClone.Models
{
    public class Attraction
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
        public int ReviewCount { get; set; }
        public string Category { get; set; }
        public bool IsPopular { get; set; }
        public DateTime AvailableDate { get; set; }
    }
} 