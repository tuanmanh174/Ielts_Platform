using Microsoft.AspNetCore.Identity;
using System;

namespace DataAccess.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
