using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class EmailMessage
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string ToEmail { get; set; }
        
        [MaxLength(100)]
        public string ToName { get; set; }
        
        [MaxLength(200)]
        public string CcEmails { get; set; } // Comma separated
        
        [MaxLength(200)]
        public string BccEmails { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Subject { get; set; }
        
        [Required]
        public string Body { get; set; }
        
        public string AttachmentPaths { get; set; } // JSON array
        
        [MaxLength(50)]
        public string Status { get; set; } // (قيد الإرسال/مرسل/فشل)
        
        public DateTime? SentAt { get; set; }
        
        public DateTime ScheduledAt { get; set; }
        
        [MaxLength(500)]
        public string ErrorMessage { get; set; }
        
        public int? EmployeeId { get; set; }
        
        public string SentByUserId { get; set; }
        
        public DateTime CreatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        
        [ForeignKey("SentByUserId")]
        public virtual AppUser SentByUser { get; set; }
    }
}
