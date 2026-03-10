using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class CalendarEvent
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        [Required]
        public DateTime StartDate { get; set; }
        
        [Required]
        public DateTime EndDate { get; set; }
        
        public bool IsAllDay { get; set; } = false;
        
        [MaxLength(50)]
        public string EventType { get; set; } // (اجتماع/موعد/حدث/إجازة/احتفال)
        
        [MaxLength(500)]
        public string Location { get; set; }
        
        [MaxLength(50)]
        public string Color { get; set; } // للتمييز البصري
        
        public bool IsRecurring { get; set; } = false;
        
        [MaxLength(50)]
        public string RecurringPattern { get; set; } // (يومي/أسبوعي/شهري/سنوي)
        
        public DateTime? RecurringEndDate { get; set; }
        
        [MaxLength(50)]
        public string Status { get; set; } // (مجدول/قيد التنفيذ/مكتمل/ملغي)
        
        public bool SendReminder { get; set; } = false;
        
        public int? ReminderMinutesBefore { get; set; }
        
        public int? CreatedByUserId { get; set; }
        
        public int? DepartmentId { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
    }
}
