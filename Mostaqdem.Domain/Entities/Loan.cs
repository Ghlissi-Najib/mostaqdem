using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Loan
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string LoanNumber { get; set; }
        
        [Required]
        public int EmployeeId { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; } // المبلغ الكلي
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal PaidAmount { get; set; } // المبلغ المدفوع
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal RemainingAmount { get; set; } // المبلغ المتبقي
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal MonthlyInstallment { get; set; } // القسط الشهري
        
        public int TotalInstallments { get; set; } // عدد الأقساط
        
        public int PaidInstallments { get; set; } // الأقساط المدفوعة
        
        public DateTime StartDate { get; set; }
        
        public DateTime? EndDate { get; set; }
        
        [MaxLength(50)]
        public string Status { get; set; } // (نشط/مكتمل/ملغي)
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        
        public virtual ICollection<LoanInstallment> LoanInstallments { get; set; }
    }
}
