using Microsoft.AspNetCore.Identity;
using System;

namespace AV_P.Data
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}