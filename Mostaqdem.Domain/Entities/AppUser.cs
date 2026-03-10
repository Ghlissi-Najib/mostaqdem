using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Mostaqdem.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Leave> ApprovedLeaves { get; set; }
    }
}
