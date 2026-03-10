using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class ProductionCode
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Code { get; set; } // كود الإنتاج
        
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Type { get; set; } // نوع الإنتاج
        
        [MaxLength(50)]
        public string StorageLocation { get; set; } // موضع التخزين
        
        public int Quantity { get; set; }
        
        [MaxLength(50)]
        public string Status { get; set; } // الحالة
        
        public DateTime? ProductionDate { get; set; }
        
        public DateTime? ExpiryDate { get; set; }
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public bool IsActive { get; set; } = true;
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
