using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class VisaApplication
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string VisaNumber { get; set; } // رقم التأشيرة
        
        [Required]
        public int EmployeeId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Gender { get; set; } // الجنس
        
        [Required]
        [MaxLength(50)]
        public string Nationality { get; set; } // الجنسية
        
        [MaxLength(100)]
        public string Profession { get; set; } // المهنة
        
        public int? WorkerCount { get; set; } // عدد العمال
        
        public int? UsedCount { get; set; } // المستخدم
        
        public int? RemainingCount { get; set; } // المتبقي
        
        public DateTime ApplicationDate { get; set; } // تاريخ الطلب
        
        [Required]
        [MaxLength(50)]
        public string Status { get; set; } // (مستخدم/منتهي/قيد المعالجة)
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
