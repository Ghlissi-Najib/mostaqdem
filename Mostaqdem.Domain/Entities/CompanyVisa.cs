using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class CompanyVisa
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string VisaNumber { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Nationality { get; set; }
        
        [Required]
        [MaxLength(10)]
        public string Gender { get; set; }
        
        [MaxLength(100)]
        public string Profession { get; set; }
        
        public int TotalQuota { get; set; } // الحصة الكلية
        
        public int UsedQuota { get; set; } // المستخدم
        
        public int AvailableQuota { get; set; } // المتاح
        
        public DateTime IssueDate { get; set; }
        
        public DateTime? ExpiryDate { get; set; }
        
        [MaxLength(50)]
        public string Status { get; set; } // (نشطة/منتهية/ملغاة)
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Cost { get; set; }
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation Properties
        public virtual ICollection<VisaUsage> VisaUsages { get; set; }
    }
}
