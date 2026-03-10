using System;
using System.ComponentModel.DataAnnotations;

namespace Mostaqdem.Domain.Entities
{
    public class NewsletterSubscriber
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        
        [MaxLength(100)]
        public string Name { get; set; }
        
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        
        public bool IsActive { get; set; } = true;
        
        public DateTime SubscribedAt { get; set; }
        
        public DateTime? UnsubscribedAt { get; set; }
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public DateTime CreatedAt { get; set; }
    }
}
