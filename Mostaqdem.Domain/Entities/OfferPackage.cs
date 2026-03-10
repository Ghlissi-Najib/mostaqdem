using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class OfferPackage
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string NameAr { get; set; }
        
        [MaxLength(100)]
        public string NameEn { get; set; }
        
        [MaxLength(1000)]
        public string Description { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        
        [MaxLength(50)]
        public string Duration { get; set; } // (شهري/ربع سنوي/سنوي)
        
        public int? MaxEmployees { get; set; } // الحد الأقصى للموظفين
        
        public int? MaxUsers { get; set; } // الحد الأقصى للمستخدمين
        
        [MaxLength(2000)]
        public string Features { get; set; } // JSON array of features
        
        public bool IsActive { get; set; } = true;
        
        public bool IsFeatured { get; set; } = false; // باقة مميزة
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation Properties
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
