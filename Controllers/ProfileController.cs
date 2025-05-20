using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Max.Models;
using Microsoft.AspNetCore.Hosting;

namespace Max.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        public ProfileController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult Index()
        {
            // In a real application, you would fetch the user's profile from the database
            // For now, we'll create a sample profile
            var profile = new UserProfile
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                PhoneNumber = "+1234567890",
                Address = "123 Main St",
                City = "New York",
                Country = "USA",
                Bio = "Travel enthusiast and adventure seeker",
                ProfileImage = null,
                TotalBookings = 5,
                MemberSince = DateTime.Now.AddYears(-1)
            };

            return View(profile);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] UserProfile profile)
        {
            try
            {
                // In a real application, you would update the user's profile in the database
                // For now, we'll just return a success response
                return Ok(new { message = "Profile updated successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Failed to update profile", error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> UploadImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                if (file == null || file.Length == 0)
                {
                    return BadRequest(new { message = "No file uploaded" });
                }

                // Create uploads directory if it doesn't exist
                var uploadsFolder = Path.Combine(_environment.WebRootPath, "uploads", "profile-images");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                // Generate unique filename
                var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
                var filePath = Path.Combine(uploadsFolder, fileName);

                // Save the file
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                // Return the URL of the uploaded image
                var imageUrl = $"/uploads/profile-images/{fileName}";
                return Ok(new { imageUrl });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Failed to upload image", error = ex.Message });
            }
        }
    }
} 