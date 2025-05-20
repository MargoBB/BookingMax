using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookingClone.Models; // Доступ до Booking
using System;
using System.Collections.Generic;

namespace BookingClone.Tests
{
    [TestClass]
    public class BookingTests
    {
        [TestMethod]
        public void HotelBooking_CanSetAndGetProperties()
        {
            // Arrange
            var booking = new HotelBooking
            {
                Id = 1,
                Type = "Hotel",
                Price = 150.00m,
                Date = new DateTime(2024, 3, 15),
                HotelName = "Grand Hotel"
            };

            // Assert
            Assert.AreEqual(1, booking.Id);
            Assert.AreEqual("Hotel", booking.Type);
            Assert.AreEqual(150.00m, booking.Price);
            Assert.AreEqual(new DateTime(2024, 3, 15), booking.Date);
            Assert.AreEqual("Grand Hotel", booking.HotelName);
        }

        [TestMethod]
        public void HotelBooking_GetDetails_ReturnsCorrectFormat()
        {
            // Arrange
            var booking = new HotelBooking
            {
                HotelName = "Grand Hotel",
                Price = 150.00m
            };

            // Act
            var details = booking.GetDetails();

            // Assert
            Assert.AreEqual("Hotel: Grand Hotel, Price: 150.00", details);
        }

        [TestMethod]
        public void HotelBooking_PriceCanBeZero()
        {
            // Arrange
            var booking = new HotelBooking
            {
                Price = 0m
            };

            // Assert
            Assert.AreEqual(0m, booking.Price);
        }

        [TestMethod]
        public void HotelBooking_PriceCanBeNegative()
        {
            // Arrange
            var booking = new HotelBooking
            {
                Price = -50m
            };

            // Assert
            Assert.AreEqual(-50m, booking.Price);
        }

        [TestMethod]
        public void HotelBooking_DateCanBeSetToFuture()
        {
            // Arrange
            var futureDate = DateTime.Now.AddDays(30);
            var booking = new HotelBooking
            {
                Date = futureDate
            };

            // Assert
            Assert.AreEqual(futureDate, booking.Date);
        }

        [TestMethod]
        public void HotelBooking_DateCanBeSetToPast()
        {
            // Arrange
            var pastDate = DateTime.Now.AddDays(-30);
            var booking = new HotelBooking
            {
                Date = pastDate
            };

            // Assert
            Assert.AreEqual(pastDate, booking.Date);
        }

        [TestMethod]
        public void HotelBooking_TypeCanBeChanged()
        {
            // Arrange
            var booking = new HotelBooking
            {
                Type = "Hotel"
            };

            // Act
            booking.Type = "Resort";

            // Assert
            Assert.AreEqual("Resort", booking.Type);
        }
    }

    [TestClass]
    public class AttractionTests
    {
        [TestMethod]
        public void Attraction_CanSetAndGetProperties()
        {
            // Arrange
            var attraction = new Attraction
            {
                Id = 1,
                Title = "Eiffel Tower Tour",
                Description = "Guided tour of the Eiffel Tower",
                ImageUrl = "eiffel.jpg",
                Price = 50.00m,
                Currency = "EUR",
                Location = "Paris, France",
                Rating = 4.5,
                ReviewCount = 1000,
                Category = "Landmarks",
                IsPopular = true,
                AvailableDate = new DateTime(2024, 3, 15)
            };

            // Assert
            Assert.AreEqual(1, attraction.Id);
            Assert.AreEqual("Eiffel Tower Tour", attraction.Title);
            Assert.AreEqual("Guided tour of the Eiffel Tower", attraction.Description);
            Assert.AreEqual("eiffel.jpg", attraction.ImageUrl);
            Assert.AreEqual(50.00m, attraction.Price);
            Assert.AreEqual("EUR", attraction.Currency);
            Assert.AreEqual("Paris, France", attraction.Location);
            Assert.AreEqual(4.5, attraction.Rating);
            Assert.AreEqual(1000, attraction.ReviewCount);
            Assert.AreEqual("Landmarks", attraction.Category);
            Assert.IsTrue(attraction.IsPopular);
            Assert.AreEqual(new DateTime(2024, 3, 15), attraction.AvailableDate);
        }
    }

    [TestClass]
    public class FlightTests
    {
        [TestMethod]
        public void Flight_CanSetAndGetProperties()
        {
            // Arrange
            var flight = new Flight
            {
                Id = 1,
                Airline = "Delta",
                FlightNumber = "DL123",
                DepartureCity = "New York",
                ArrivalCity = "London",
                DepartureTime = new DateTime(2024, 3, 15, 10, 0, 0),
                ArrivalTime = new DateTime(2024, 3, 15, 22, 0, 0),
                Price = 500.00m,
                Currency = "USD",
                Class = "Business",
                IsDirect = true,
                AvailableSeats = 50
            };

            // Assert
            Assert.AreEqual(1, flight.Id);
            Assert.AreEqual("Delta", flight.Airline);
            Assert.AreEqual("DL123", flight.FlightNumber);
            Assert.AreEqual("New York", flight.DepartureCity);
            Assert.AreEqual("London", flight.ArrivalCity);
            Assert.AreEqual(new DateTime(2024, 3, 15, 10, 0, 0), flight.DepartureTime);
            Assert.AreEqual(new DateTime(2024, 3, 15, 22, 0, 0), flight.ArrivalTime);
            Assert.AreEqual(500.00m, flight.Price);
            Assert.AreEqual("USD", flight.Currency);
            Assert.AreEqual("Business", flight.Class);
            Assert.IsTrue(flight.IsDirect);
            Assert.AreEqual(50, flight.AvailableSeats);
        }

        [TestMethod]
        public void Flight_DefaultValuesAreSet()
        {
            // Arrange
            var flight = new Flight();

            // Assert
            Assert.AreEqual("USD", flight.Currency);
            Assert.AreEqual("Economy", flight.Class);
        }
    }

    [TestClass]
    public class CarRentalTests
    {
        [TestMethod]
        public void CarRental_CanSetAndGetProperties()
        {
            // Arrange
            var carRental = new CarRental
            {
                Id = 1,
                CarModel = "Toyota Camry",
                CarType = "Sedan",
                Location = "Los Angeles",
                PricePerDay = 75.00m,
                Currency = "USD",
                ImageUrl = "camry.jpg",
                Features = new List<string> { "GPS", "Bluetooth", "Air Conditioning" },
                Transmission = "Automatic",
                FuelType = "Petrol",
                Seats = 5,
                Bags = 3,
                Available = true
            };

            // Assert
            Assert.AreEqual(1, carRental.Id);
            Assert.AreEqual("Toyota Camry", carRental.CarModel);
            Assert.AreEqual("Sedan", carRental.CarType);
            Assert.AreEqual("Los Angeles", carRental.Location);
            Assert.AreEqual(75.00m, carRental.PricePerDay);
            Assert.AreEqual("USD", carRental.Currency);
            Assert.AreEqual("camry.jpg", carRental.ImageUrl);
            Assert.AreEqual(3, carRental.Features.Count);
            Assert.AreEqual("Automatic", carRental.Transmission);
            Assert.AreEqual("Petrol", carRental.FuelType);
            Assert.AreEqual(5, carRental.Seats);
            Assert.AreEqual(3, carRental.Bags);
            Assert.IsTrue(carRental.Available);
        }

        [TestMethod]
        public void CarRental_DefaultValuesAreSet()
        {
            // Arrange
            var carRental = new CarRental();

            // Assert
            Assert.AreEqual("USD", carRental.Currency);
            Assert.AreEqual("Automatic", carRental.Transmission);
            Assert.AreEqual("Petrol", carRental.FuelType);
            Assert.IsNotNull(carRental.Features);
            Assert.AreEqual(0, carRental.Features.Count);
        }
    }

    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void User_CanSetAndGetProperties()
        {
            // Arrange
            var user = new User
            {
                Id = 1,
                Email = "john.doe@example.com",
                PasswordHash = "hashedPassword123",
                FirstName = "John",
                LastName = "Doe",
                Role = "Customer",
                PhoneNumber = "+1234567890",
                Address = "123 Main St",
                CreatedAt = new DateTime(2024, 1, 1)
            };

            // Assert
            Assert.AreEqual(1, user.Id);
            Assert.AreEqual("john.doe@example.com", user.Email);
            Assert.AreEqual("hashedPassword123", user.PasswordHash);
            Assert.AreEqual("John", user.FirstName);
            Assert.AreEqual("Doe", user.LastName);
            Assert.AreEqual("Customer", user.Role);
            Assert.AreEqual("+1234567890", user.PhoneNumber);
            Assert.AreEqual("123 Main St", user.Address);
            Assert.AreEqual(new DateTime(2024, 1, 1), user.CreatedAt);
        }

        [TestMethod]
        public void User_DefaultValuesAreSet()
        {
            // Arrange
            var user = new User();

            // Assert
            Assert.AreEqual("Customer", user.Role);
            Assert.IsTrue(user.CreatedAt <= DateTime.UtcNow);
            Assert.IsTrue(user.CreatedAt >= DateTime.UtcNow.AddMinutes(-1));
        }

        [TestMethod]
        public void User_OptionalPropertiesCanBeNull()
        {
            // Arrange
            var user = new User
            {
                Email = "test@example.com",
                PasswordHash = "hash",
                FirstName = "Test",
                LastName = "User"
            };

            // Assert
            Assert.IsNull(user.PhoneNumber);
            Assert.IsNull(user.Address);
        }
    }
}