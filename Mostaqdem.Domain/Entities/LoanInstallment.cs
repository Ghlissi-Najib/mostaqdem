using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class LoanInstallment
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int LoanId { get; set; }
        
        public int InstallmentNumber { get; set; } // رقم القسط
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        
        public DateTime DueDate { get; set; } // تاريخ الاستحقاق
        
        public DateTime? PaidDate { get; set; } // تاريخ الدفع
        
        [MaxLength(50)]
        public string Status { get; set; } // (قيد الانتظار/مدفوع/متأخر)
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("LoanId")]
        public virtual Loan Loan { get; set; }
    }
}
