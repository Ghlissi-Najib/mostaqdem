using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Attendance
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int EmployeeId { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
        
        public TimeSpan? CheckInTime { get; set; } // وقت الحضور
        
        public TimeSpan? CheckOutTime { get; set; } // وقت الانصراف
        
        [MaxLength(50)]
        public string Status { get; set; } // الحالة (حاضر/غائب/متأخر)
        
        public int? LateMinutes { get; set; } // دقائق التأخير
        
        public int? EarlyLeaveMinutes { get; set; } // دقائق الانصراف المبكر
        
        public int? OvertimeMinutes { get; set; } // دقائق العمل الإضافي
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
