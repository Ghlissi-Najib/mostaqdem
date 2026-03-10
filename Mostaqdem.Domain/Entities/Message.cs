using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string SenderUserId { get; set; }
        
        [Required]
        public string RecipientUserId { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Subject { get; set; }
        
        [Required]
        public string Body { get; set; }
        
        public bool IsRead { get; set; } = false;
        
        public DateTime? ReadAt { get; set; }
        
        public bool IsSenderDeleted { get; set; } = false;
        
        public bool IsRecipientDeleted { get; set; } = false;
        
        public int? ParentMessageId { get; set; } // للرد على الرسائل
        
        public DateTime SentAt { get; set; }
        
        public DateTime CreatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("SenderUserId")]
        public virtual AppUser Sender { get; set; }
        
        [ForeignKey("RecipientUserId")]
        public virtual AppUser Recipient { get; set; }
        
        [ForeignKey("ParentMessageId")]
        public virtual Message ParentMessage { get; set; }
    }
}
