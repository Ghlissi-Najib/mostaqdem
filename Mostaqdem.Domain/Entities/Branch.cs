using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mostaqdem.Domain.Entities
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string BranchCode { get; set; } // كود الفرع
        
        [Required]
        [MaxLength(100)]
        public string NameAr { get; set; }
        
        [MaxLength(100)]
        public string NameEn { get; set; }
        
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        
        [MaxLength(100)]
        public string Email { get; set; }
        
        [MaxLength(500)]
        public string Address { get; set; }
        
        [MaxLength(100)]
        public string City { get; set; }
        
        [MaxLength(100)]
        public string Region { get; set; }
        
        [MaxLength(20)]
        public string PostalCode { get; set; }
        
        [MaxLength(100)]
        public string ManagerName { get; set; }
        
        public bool IsHeadOffice { get; set; } = false; // المقر الرئيسي
        
        public bool IsActive { get; set; } = true;
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation Properties
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
