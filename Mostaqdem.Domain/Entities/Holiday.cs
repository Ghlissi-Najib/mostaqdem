using System;
using System.ComponentModel.DataAnnotations;

namespace Mostaqdem.Domain.Entities
{
    public class Holiday
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string NameAr { get; set; }
        
        [MaxLength(100)]
        public string NameEn { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
        
        public DateTime? EndDate { get; set; } // في حالة إجازة متعددة الأيام
        
        [MaxLength(50)]
        public string Type { get; set; } // (رسمية/دينية/وطنية)
        
        public bool IsPaid { get; set; } = true;
        
        public bool IsRecurring { get; set; } = false; // تتكرر سنويا
        
        [MaxLength(500)]
        public string Description { get; set; }
        
        public bool IsActive { get; set; } = true;
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
