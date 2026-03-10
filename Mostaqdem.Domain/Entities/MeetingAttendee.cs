using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class MeetingAttendee
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int MeetingId { get; set; }
        
        public int? EmployeeId { get; set; }
        
        public string UserId { get; set; }
        
        [MaxLength(50)]
        public string ResponseStatus { get; set; } // (قبول/رفض/ربما/قيد الانتظار)
        
        public bool IsRequired { get; set; } = true; // حضور إلزامي
        
        public bool HasAttended { get; set; } = false; // حضر فعليا
        
        public DateTime? ResponseDate { get; set; }
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public DateTime CreatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("MeetingId")]
        public virtual Meeting Meeting { get; set; }
        
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        
        [ForeignKey("UserId")]
        public virtual AppUser User { get; set; }
    }
}
