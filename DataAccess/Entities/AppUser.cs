using Microsoft.AspNetCore.Identity;
using System;

namespace DataAccess.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public int SchoolId { get; set; }
    }
}
