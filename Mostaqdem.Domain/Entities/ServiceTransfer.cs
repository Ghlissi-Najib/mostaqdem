using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class ServiceTransfer
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string RequestNumber { get; set; } // رقم الطلب
        
        [Required]
        public int EmployeeId { get; set; }
        
        public DateTime RequestDate { get; set; } // تاريخ الطلب
        
        [MaxLength(50)]
        public string PaymentStatus { get; set; } // حالة الدفع (مدفوع/غير مدفوع/قيد المعالجة)
        
        [MaxLength(50)]
        public string TransferStatus { get; set; } // حالة الطلب (مكتملة/قيد المعالجة)
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
