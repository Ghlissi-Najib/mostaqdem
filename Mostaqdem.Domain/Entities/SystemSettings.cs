using System;
using System.ComponentModel.DataAnnotations;

namespace Mostaqdem.Domain.Entities
{
    public class SystemSettings
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string SettingKey { get; set; }
        
        [Required]
        public string SettingValue { get; set; }
        
        [MaxLength(200)]
        public string Description { get; set; }
        
        [MaxLength(50)]
        public string Category { get; set; } // (عام/حضور/رواتب/إجازات)
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
