using System;

namespace Max.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Bio { get; set; }
        public string ProfileImage { get; set; }
        public int TotalBookings { get; set; }
        public DateTime MemberSince { get; set; }
    }
} 