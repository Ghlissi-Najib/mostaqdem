using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Subscription
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string SubscriptionNumber { get; set; }
        
        [Required]
        public int OfferPackageId { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string CompanyName { get; set; }
        
        [MaxLength(100)]
        public string ContactEmail { get; set; }
        
        [MaxLength(20)]
        public string ContactPhone { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        
        [MaxLength(50)]
        public string Status { get; set; } // (نشط/منتهي/معلق)
        
        [MaxLength(50)]
        public string PaymentStatus { get; set; } // (مدفوع/غير مدفوع)
        
        public bool AutoRenew { get; set; } = false;
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("OfferPackageId")]
        public virtual OfferPackage OfferPackage { get; set; }
    }
}
