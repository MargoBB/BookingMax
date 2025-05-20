using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using BookingClone.Models;

namespace BookingClone.Controllers
{
    public class FlightsController : Controller
    {
        public IActionResult Index()
        {
            // Sample data for demonstration
            var flights = new List<Flight>
            {
                new Flight
                {
                    Id = 1,
                    Airline = "British Airways",
                    FlightNumber = "BA123",
                    DepartureCity = "London",
                    ArrivalCity = "Paris",
                    DepartureTime = DateTime.Now.AddDays(1),
                    ArrivalTime = DateTime.Now.AddDays(1).AddHours(1.5),
                    Price = 150,
                    Currency = "GBP",
                    Class = "Economy",
                    IsDirect = true,
                    AvailableSeats = 45
                },
                new Flight
                {
                    Id = 2,
                    Airline = "Emirates",
                    FlightNumber = "EK202",
                    DepartureCity = "Dubai",
                    ArrivalCity = "New York",
                    DepartureTime = DateTime.Now.AddDays(2),
                    ArrivalTime = DateTime.Now.AddDays(2).AddHours(14),
                    Price = 850,
                    Currency = "USD",
                    Class = "Business",
                    IsDirect = true,
                    AvailableSeats = 12
                },
                new Flight
                {
                    Id = 3,
                    Airline = "Singapore Airlines",
                    FlightNumber = "SQ321",
                    DepartureCity = "Singapore",
                    ArrivalCity = "Sydney",
                    DepartureTime = DateTime.Now.AddDays(3),
                    ArrivalTime = DateTime.Now.AddDays(3).AddHours(8),
                    Price = 650,
                    Currency = "SGD",
                    Class = "Economy",
                    IsDirect = true,
                    AvailableSeats = 78
                },
                new Flight
                {
                    Id = 4,
                    Airline = "Lufthansa",
                    FlightNumber = "LH400",
                    DepartureCity = "Frankfurt",
                    ArrivalCity = "Tokyo",
                    DepartureTime = DateTime.Now.AddDays(4),
                    ArrivalTime = DateTime.Now.AddDays(4).AddHours(12),
                    Price = 720,
                    Currency = "EUR",
                    Class = "Premium Economy",
                    IsDirect = true,
                    AvailableSeats = 25
                },
                new Flight
                {
                    Id = 5,
                    Airline = "Qatar Airways",
                    FlightNumber = "QR701",
                    DepartureCity = "Doha",
                    ArrivalCity = "Cape Town",
                    DepartureTime = DateTime.Now.AddDays(5),
                    ArrivalTime = DateTime.Now.AddDays(5).AddHours(9),
                    Price = 680,
                    Currency = "USD",
                    Class = "Business",
                    IsDirect = true,
                    AvailableSeats = 18
                },
                new Flight
                {
                    Id = 6,
                    Airline = "Cathay Pacific",
                    FlightNumber = "CX888",
                    DepartureCity = "Hong Kong",
                    ArrivalCity = "Vancouver",
                    DepartureTime = DateTime.Now.AddDays(6),
                    ArrivalTime = DateTime.Now.AddDays(6).AddHours(11),
                    Price = 890,
                    Currency = "HKD",
                    Class = "Economy",
                    IsDirect = true,
                    AvailableSeats = 65
                },
                new Flight
                {
                    Id = 7,
                    Airline = "Turkish Airlines",
                    FlightNumber = "TK1234",
                    DepartureCity = "Istanbul",
                    ArrivalCity = "Bangkok",
                    DepartureTime = DateTime.Now.AddDays(7),
                    ArrivalTime = DateTime.Now.AddDays(7).AddHours(8),
                    Price = 450,
                    Currency = "TRY",
                    Class = "Economy",
                    IsDirect = true,
                    AvailableSeats = 92
                },
                new Flight
                {
                    Id = 8,
                    Airline = "Air France",
                    FlightNumber = "AF456",
                    DepartureCity = "Paris",
                    ArrivalCity = "Rio de Janeiro",
                    DepartureTime = DateTime.Now.AddDays(8),
                    ArrivalTime = DateTime.Now.AddDays(8).AddHours(11),
                    Price = 780,
                    Currency = "EUR",
                    Class = "Business",
                    IsDirect = true,
                    AvailableSeats = 15
                },
                new Flight
                {
                    Id = 9,
                    Airline = "ANA",
                    FlightNumber = "NH123",
                    DepartureCity = "Tokyo",
                    ArrivalCity = "Seoul",
                    DepartureTime = DateTime.Now.AddDays(9),
                    ArrivalTime = DateTime.Now.AddDays(9).AddHours(2),
                    Price = 320,
                    Currency = "JPY",
                    Class = "Economy",
                    IsDirect = true,
                    AvailableSeats = 120
                },
                new Flight
                {
                    Id = 10,
                    Airline = "Virgin Atlantic",
                    FlightNumber = "VS123",
                    DepartureCity = "London",
                    ArrivalCity = "Los Angeles",
                    DepartureTime = DateTime.Now.AddDays(10),
                    ArrivalTime = DateTime.Now.AddDays(10).AddHours(11),
                    Price = 650,
                    Currency = "GBP",
                    Class = "Premium Economy",
                    IsDirect = true,
                    AvailableSeats = 35
                }
            };

            return View(flights);
        }

        public IActionResult Search(string from, string to, DateTime departureDate, DateTime? returnDate, int passengers)
        {
            // TODO: Implement flight search logic
            return View("Index");
        }
    }
} 