using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Report
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string ReportName { get; set; }
        
        [MaxLength(500)]
        public string Description { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string ReportType { get; set; } // (الحضور/الرواتب/الإجازات/الموظفين/المالية)
        
        [MaxLength(50)]
        public string ReportCategory { get; set; } // (يومي/شهري/سنوي/مخصص)
        
        public string Parameters { get; set; } // JSON parameters
        
        public DateTime? GeneratedDate { get; set; }
        
        public string GeneratedFilePath { get; set; }
        
        [MaxLength(50)]
        public string FileFormat { get; set; } // (PDF/Excel/CSV)
        
        public string GeneratedByUserId { get; set; }
        
        public bool IsScheduled { get; set; } = false;
        
        [MaxLength(50)]
        public string ScheduleFrequency { get; set; } // (يومي/أسبوعي/شهري)
        
        public DateTime? NextScheduledDate { get; set; }
        
        public string RecipientEmails { get; set; } // Comma separated
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("GeneratedByUserId")]
        public virtual AppUser GeneratedByUser { get; set; }
    }
}
