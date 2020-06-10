using Microsoft.AspNetCore.Identity;
using System;

namespace AV_P.Data
{
    
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }


    }
}
