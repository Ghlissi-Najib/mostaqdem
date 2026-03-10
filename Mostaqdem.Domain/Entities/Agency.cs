using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mostaqdem.Domain.Entities
{
    public class Agency
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        
        [MaxLength(100)]
        public string Email { get; set; }
        
        [MaxLength(500)]
        public string Address { get; set; }
        
        [MaxLength(50)]
        public string ContactPerson { get; set; }
        
        public bool IsActive { get; set; } = true;
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation Properties
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
