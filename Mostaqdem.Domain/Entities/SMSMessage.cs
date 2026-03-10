using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class SMSMessage
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string RecipientPhone { get; set; } // رقم المستلم
        
        [MaxLength(100)]
        public string RecipientName { get; set; }
        
        [Required]
        public string Message { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string MessageType { get; set; } // (رسالة نصية/رسالة WhatsApp/رسالة اتصال)
        
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
