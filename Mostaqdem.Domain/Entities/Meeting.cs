using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Meeting
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        
        public string Agenda { get; set; } // جدول الأعمال
        
        [Required]
        public DateTime StartTime { get; set; }
        
        [Required]
        public DateTime EndTime { get; set; }
        
        [MaxLength(500)]
        public string Location { get; set; }
        
        [MaxLength(500)]
        public string MeetingLink { get; set; } // رابط الاجتماع الافتراضي
        
        [MaxLength(50)]
        public string MeetingType { get; set; } // (حضوري/افتراضي/مختلط)
        
        [MaxLength(50)]
        public string Status { get; set; } // (مجدول/قيد التنفيذ/مكتمل/ملغي)
        
        public string Minutes { get; set; } // محضر الاجتماع
        
        public string Decisions { get; set; } // القرارات
        
        public string ActionItems { get; set; } // بنود العمل
        
        public int? OrganizerUserId { get; set; }
        
        public string AttachmentPaths { get; set; } // JSON array
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation Properties
        public virtual ICollection<MeetingAttendee> MeetingAttendees { get; set; }
    }
}
