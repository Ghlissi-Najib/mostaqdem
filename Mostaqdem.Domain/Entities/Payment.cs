using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string PaymentNumber { get; set; } // رقم الدفعة
        
        public int? InvoiceId { get; set; }
        
        public int? EmployeeId { get; set; } // في حالة دفعات الموظفين
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        
        public DateTime PaymentDate { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string PaymentMethod { get; set; } // (نقدي/تحويل/شيك/بطاقة)
        
        [MaxLength(100)]
        public string ReferenceNumber { get; set; } // رقم المرجع/الشيك
        
        [MaxLength(50)]
        public string PaymentType { get; set; } // (وارد/صادر)
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public string ReceivedByUserId { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("InvoiceId")]
        public virtual Invoice Invoice { get; set; }
        
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        
        [ForeignKey("ReceivedByUserId")]
        public virtual AppUser ReceivedByUser { get; set; }
    }
}
