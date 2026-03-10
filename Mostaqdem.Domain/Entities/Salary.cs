using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Salary
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int EmployeeId { get; set; }
        
        [Required]
        public int Month { get; set; } // الشهر
        
        [Required]
        public int Year { get; set; } // السنة
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal BasicSalary { get; set; } // الراتب الأساسي
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAllowances { get; set; } // إجمالي البدلات
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalDeductions { get; set; } // إجمالي الخصومات
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal OvertimePay { get; set; } // أجر العمل الإضافي
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal NetSalary { get; set; } // صافي الراتب
        
        [MaxLength(50)]
        public string PaymentStatus { get; set; } // حالة الدفع
        
        public DateTime? PaymentDate { get; set; }
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
