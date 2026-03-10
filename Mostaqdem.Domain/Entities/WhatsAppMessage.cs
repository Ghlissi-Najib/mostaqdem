using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class WhatsAppMessage
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string RecipientPhone { get; set; }
        
        [MaxLength(100)]
        public string RecipientName { get; set; }
        
        [Required]
        public string Message { get; set; }
        
        [MaxLength(50)]
        public string MessageType { get; set; } // (نص/صورة/ملف)
        
        public string AttachmentUrl { get; set; }
        
        [MaxLength(50)]
        public string Status { get; set; } // (قيد الإرسال/مرسل/مقروء/فشل)
        
        public DateTime? SentAt { get; set; }
        
        public DateTime? ReadAt { get; set; }
        
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
