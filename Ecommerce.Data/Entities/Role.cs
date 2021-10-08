using System;
using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Data.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}