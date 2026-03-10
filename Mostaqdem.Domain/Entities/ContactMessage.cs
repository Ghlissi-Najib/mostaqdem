using System;
using System.ComponentModel.DataAnnotations;

namespace Mostaqdem.Domain.Entities
{
    public class ContactMessage
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Subject { get; set; }
        
        [Required]
        public string Message { get; set; }
        
        [MaxLength(50)]
        public string Status { get; set; } // (جديد/قيد المراجعة/تم الرد/مغلق)
        
        public bool IsRead { get; set; } = false;
        
        public DateTime? ReadAt { get; set; }
        
        public string Reply { get; set; }
        
        public DateTime? RepliedAt { get; set; }
        
        public string RepliedByUserId { get; set; }
        
        public DateTime CreatedAt { get; set; }
    }
}
