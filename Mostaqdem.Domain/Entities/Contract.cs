using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Contract
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string ContractNumber { get; set; } // رقم العقد
        
        [Required]
        public int EmployeeId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string ContractType { get; set; } // نوع العقد (محدود/غير محدود)
        
        public DateTime StartDate { get; set; } // تاريخ البداية
        
        public DateTime? EndDate { get; set; } // تاريخ النهاية
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
        
        [MaxLength(1000)]
        public string Terms { get; set; } // شروط العقد
        
        [MaxLength(50)]
        public string Status { get; set; } // الحالة (فعال/منتهي/ملغي)
        
        public string DocumentPath { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
