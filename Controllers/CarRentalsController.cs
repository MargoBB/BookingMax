using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using BookingClone.Models;

namespace BookingClone.Controllers
{
    public class CarRentalsController : Controller
    {
        public IActionResult Index()
        {
            // Sample data for demonstration
            var carRentals = new List<CarRental>
            {
                new CarRental
                {
                    Id = 1,
                    CarModel = "Toyota Camry",
                    CarType = "Sedan",
                    Location = "London",
                    PricePerDay = 50,
                    Currency = "GBP",
                    ImageUrl = "https://images.unsplash.com/photo-1513635269975-59663e0ac1ad",
                    Features = new List<string> { "Air Conditioning", "Bluetooth", "GPS", "Cruise Control" },
                    Transmission = "Automatic",
                    FuelType = "Petrol",
                    Seats = 5,
                    Bags = 3,
                    Available = true
                }
            };

            return View(carRentals);
        }

        public IActionResult Search(string location, DateTime pickupDate, DateTime dropoffDate)
        {
            // TODO: Implement car rental search logic
            return View("Index");
        }
    }
} 