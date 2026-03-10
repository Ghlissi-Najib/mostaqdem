using System;
using System.ComponentModel.DataAnnotations;

namespace Mostaqdem.Domain.Entities
{
    public class Page
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string TitleAr { get; set; }
        
        [MaxLength(200)]
        public string TitleEn { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Slug { get; set; } // URL slug
        
        public string ContentAr { get; set; } // HTML content
        
        public string ContentEn { get; set; }
        
        [MaxLength(500)]
        public string MetaDescription { get; set; }
        
        [MaxLength(200)]
        public string MetaKeywords { get; set; }
        
        public int DisplayOrder { get; set; }
        
        public bool IsPublished { get; set; } = true;
        
        public bool ShowInMenu { get; set; } = false;
        
        public string CreatedByUserId { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
