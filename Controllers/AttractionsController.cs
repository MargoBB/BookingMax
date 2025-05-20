using Microsoft.AspNetCore.Mvc;
using BookingClone.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookingClone.Controllers
{
    public class AttractionsController : Controller
    {
        private static List<Attraction> _attractions = new List<Attraction>
        {
            new Attraction
            {
                Id = 1,
                Title = "London Eye",
                Description = "Experience London from above on the iconic London Eye",
                ImageUrl = "/images/london-eye.jpg",
                Price = 30.00m,
                Currency = "GBP",
                Location = "London, UK",
                Rating = 4.5,
                ReviewCount = 12500,
                Category = "Sightseeing",
                IsPopular = true,
                AvailableDate = System.DateTime.Now.AddDays(1)
            },
            new Attraction
            {
                Id = 2,
                Title = "Eiffel Tower",
                Description = "Visit the world-famous iron lattice tower on the Champ de Mars in Paris",
                ImageUrl = "/images/eiffel-tower.jpg",
                Price = 25.00m,
                Currency = "EUR",
                Location = "Paris, France",
                Rating = 4.8,
                ReviewCount = 15800,
                Category = "Sightseeing",
                IsPopular = true,
                AvailableDate = System.DateTime.Now.AddDays(2)
            },
            new Attraction
            {
                Id = 3,
                Title = "Universal Studios",
                Description = "Experience the magic of movies at Universal Studios theme park",
                ImageUrl = "/images/universal-studios.jpg",
                Price = 120.00m,
                Currency = "USD",
                Location = "Orlando, USA",
                Rating = 4.7,
                ReviewCount = 9800,
                Category = "Theme Park",
                IsPopular = true,
                AvailableDate = System.DateTime.Now.AddDays(3)
            },
            new Attraction
            {
                Id = 4,
                Title = "Safari Adventure",
                Description = "Experience wildlife up close in their natural habitat",
                ImageUrl = "/images/safari.jpg",
                Price = 150.00m,
                Currency = "USD",
                Location = "Nairobi, Kenya",
                Rating = 4.9,
                ReviewCount = 3200,
                Category = "Adventure",
                IsPopular = true,
                AvailableDate = System.DateTime.Now.AddDays(4)
            },
            new Attraction
            {
                Id = 5,
                Title = "Great Wall of China",
                Description = "Walk along one of the world's most impressive architectural feats",
                ImageUrl = "/images/great-wall.jpg",
                Price = 45.00m,
                Currency = "CNY",
                Location = "Beijing, China",
                Rating = 4.8,
                ReviewCount = 8900,
                Category = "Historical",
                IsPopular = true,
                AvailableDate = System.DateTime.Now.AddDays(5)
            },
            new Attraction
            {
                Id = 6,
                Title = "Northern Lights Tour",
                Description = "Witness the spectacular Aurora Borealis in the Arctic Circle",
                ImageUrl = "/images/northern-lights.jpg",
                Price = 180.00m,
                Currency = "EUR",
                Location = "Tromsø, Norway",
                Rating = 4.9,
                ReviewCount = 4500,
                Category = "Nature",
                IsPopular = true,
                AvailableDate = System.DateTime.Now.AddDays(6)
            },
            new Attraction
            {
                Id = 7,
                Title = "Disneyland Tokyo",
                Description = "Experience the magic of Disney in Japan",
                ImageUrl = "/images/disney-tokyo.jpg",
                Price = 85.00m,
                Currency = "JPY",
                Location = "Tokyo, Japan",
                Rating = 4.7,
                ReviewCount = 15600,
                Category = "Theme Park",
                IsPopular = true,
                AvailableDate = System.DateTime.Now.AddDays(7)
            },
            new Attraction
            {
                Id = 8,
                Title = "Pyramids of Giza",
                Description = "Explore the ancient wonders of Egypt",
                ImageUrl = "/images/pyramids.jpg",
                Price = 60.00m,
                Currency = "EGP",
                Location = "Cairo, Egypt",
                Rating = 4.8,
                ReviewCount = 7800,
                Category = "Historical",
                IsPopular = true,
                AvailableDate = System.DateTime.Now.AddDays(8)
            },
            new Attraction
            {
                Id = 9,
                Title = "Great Barrier Reef",
                Description = "Dive into the world's largest coral reef system",
                ImageUrl = "/images/reef.jpg",
                Price = 200.00m,
                Currency = "AUD",
                Location = "Queensland, Australia",
                Rating = 4.9,
                ReviewCount = 5600,
                Category = "Nature",
                IsPopular = true,
                AvailableDate = System.DateTime.Now.AddDays(9)
            },
            new Attraction
            {
                Id = 10,
                Title = "Venice Gondola Ride",
                Description = "Experience the romance of Venice on a traditional gondola",
                ImageUrl = "/images/gondola.jpg",
                Price = 80.00m,
                Currency = "EUR",
                Location = "Venice, Italy",
                Rating = 4.6,
                ReviewCount = 9200,
                Category = "Cultural",
                IsPopular = true,
                AvailableDate = System.DateTime.Now.AddDays(10)
            }
        };

        public IActionResult Index()
        {
            return View(_attractions);
        }

        public IActionResult Details(int id)
        {
            var attraction = _attractions.FirstOrDefault(a => a.Id == id);
            if (attraction == null)
            {
                return NotFound();
            }
            return View(attraction);
        }

        [HttpGet]
        public IActionResult Search(string query, string location, string category)
        {
            var results = _attractions.AsQueryable();

            if (!string.IsNullOrEmpty(query))
            {
                results = results.Where(a => a.Title.Contains(query) || a.Description.Contains(query));
            }

            if (!string.IsNullOrEmpty(location))
            {
                results = results.Where(a => a.Location.Contains(location));
            }

            if (!string.IsNullOrEmpty(category))
            {
                results = results.Where(a => a.Category == category);
            }

            return View("Index", results.ToList());
        }
    }
} 