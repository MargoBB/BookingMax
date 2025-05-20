using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using BookingClone.Models;

namespace BookingClone.Controllers
{
    public class HotelsController : Controller
    {
        public IActionResult Index()
        {
            // Sample data for demonstration
            var hotels = new List<Hotel>
            {
                new Hotel
                {
                    Id = 1,
                    Name = "Grand Hotel",
                    Description = "Luxury hotel in the heart of the city",
                    Location = "London",
                    Price = 200,
                    Currency = "GBP",
                    ImageUrl = "https://images.unsplash.com/photo-1513635269975-59663e0ac1ad",
                    Rating = 4.5,
                    ReviewCount = 1234,
                    Amenities = new List<string> { "WiFi", "Pool", "Spa", "Restaurant" }
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Seaside Resort",
                    Description = "Beachfront luxury resort with ocean views",
                    Location = "Miami",
                    Price = 350,
                    Currency = "USD",
                    ImageUrl = "https://images.unsplash.com/photo-1520250497591-112f2f40a3f4",
                    Rating = 4.8,
                    ReviewCount = 856,
                    Amenities = new List<string> { "Private Beach", "Pool", "Spa", "Water Sports" }
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Mountain View Lodge",
                    Description = "Cozy mountain retreat with stunning views",
                    Location = "Swiss Alps",
                    Price = 280,
                    Currency = "EUR",
                    ImageUrl = "https://images.unsplash.com/photo-1520250497591-112f2f40a3f4",
                    Rating = 4.6,
                    ReviewCount = 432,
                    Amenities = new List<string> { "Skiing", "Spa", "Restaurant", "Fitness Center" }
                },
                new Hotel
                {
                    Id = 4,
                    Name = "City Center Boutique",
                    Description = "Modern boutique hotel in downtown",
                    Location = "Tokyo",
                    Price = 180,
                    Currency = "JPY",
                    ImageUrl = "https://images.unsplash.com/photo-1566073771259-6a8506099945",
                    Rating = 4.4,
                    ReviewCount = 678,
                    Amenities = new List<string> { "WiFi", "Restaurant", "Bar", "Business Center" }
                },
                new Hotel
                {
                    Id = 5,
                    Name = "Desert Oasis Resort",
                    Description = "Luxury desert resort with private pools",
                    Location = "Dubai",
                    Price = 450,
                    Currency = "AED",
                    ImageUrl = "https://images.unsplash.com/photo-1542314831-068cd1dbfeeb",
                    Rating = 4.9,
                    ReviewCount = 2345,
                    Amenities = new List<string> { "Private Pool", "Spa", "Desert Safari", "Fine Dining" }
                },
                new Hotel
                {
                    Id = 6,
                    Name = "Historic Palace Hotel",
                    Description = "Converted palace with royal heritage",
                    Location = "Jaipur",
                    Price = 220,
                    Currency = "INR",
                    ImageUrl = "https://images.unsplash.com/photo-1566073771259-6a8506099945",
                    Rating = 4.7,
                    ReviewCount = 987,
                    Amenities = new List<string> { "Palace Tours", "Traditional Spa", "Royal Dining", "Cultural Shows" }
                },
                new Hotel
                {
                    Id = 7,
                    Name = "Rainforest Eco Lodge",
                    Description = "Sustainable luxury in the heart of the rainforest",
                    Location = "Costa Rica",
                    Price = 320,
                    Currency = "USD",
                    ImageUrl = "https://images.unsplash.com/photo-1520250497591-112f2f40a3f4",
                    Rating = 4.8,
                    ReviewCount = 765,
                    Amenities = new List<string> { "Eco Tours", "Wildlife Viewing", "Organic Restaurant", "Yoga Deck" }
                },
                new Hotel
                {
                    Id = 8,
                    Name = "Arctic Glass Hotel",
                    Description = "Unique glass igloos for Northern Lights viewing",
                    Location = "Lapland",
                    Price = 380,
                    Currency = "EUR",
                    ImageUrl = "https://images.unsplash.com/photo-1566073771259-6a8506099945",
                    Rating = 4.9,
                    ReviewCount = 543,
                    Amenities = new List<string> { "Northern Lights Viewing", "Sauna", "Arctic Activities", "Glass Roof" }
                },
                new Hotel
                {
                    Id = 9,
                    Name = "Vineyard Estate",
                    Description = "Luxury accommodation in a working vineyard",
                    Location = "Tuscany",
                    Price = 290,
                    Currency = "EUR",
                    ImageUrl = "https://images.unsplash.com/photo-1520250497591-112f2f40a3f4",
                    Rating = 4.7,
                    ReviewCount = 876,
                    Amenities = new List<string> { "Wine Tasting", "Vineyard Tours", "Cooking Classes", "Pool" }
                },
                new Hotel
                {
                    Id = 10,
                    Name = "Island Paradise Resort",
                    Description = "Overwater bungalows in crystal clear waters",
                    Location = "Maldives",
                    Price = 550,
                    Currency = "USD",
                    ImageUrl = "https://images.unsplash.com/photo-1566073771259-6a8506099945",
                    Rating = 4.9,
                    ReviewCount = 1234,
                    Amenities = new List<string> { "Private Beach", "Water Sports", "Spa", "Underwater Restaurant" }
                }
            };

            return View(hotels);
        }

        public IActionResult Search(string location, DateTime checkIn, DateTime checkOut, int guests)
        {
            // TODO: Implement hotel search logic
            return View("Index");
        }
    }
} 