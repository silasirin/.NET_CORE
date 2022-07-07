using Microsoft.AspNetCore.Identity;
using System;

namespace NetCoreIdentity.Models.Entity
{
    public class AppUser : IdentityUser
    {
        public DateTime BirthDate { get; set; }
    }
}
