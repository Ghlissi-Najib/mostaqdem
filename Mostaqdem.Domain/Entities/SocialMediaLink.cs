using System;
using System.ComponentModel.DataAnnotations;

namespace Mostaqdem.Domain.Entities
{
    public class SocialMediaLink
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Platform { get; set; } // (Facebook/Twitter/Instagram/LinkedIn/YouTube/TikTok)
        
        [Required]
        [MaxLength(500)]
        public string Url { get; set; }
        
        [MaxLength(100)]
        public string Username { get; set; }
        
        public int DisplayOrder { get; set; }
        
        public bool IsActive { get; set; } = true;
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
