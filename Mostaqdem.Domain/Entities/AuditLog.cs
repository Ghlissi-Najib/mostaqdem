using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class AuditLog
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Action { get; set; } // (إنشاء/تعديل/حذف/عرض)
        
        [Required]
        [MaxLength(100)]
        public string EntityName { get; set; } // اسم الجدول/الكيان
        
        public int? EntityId { get; set; } // معرف السجل
        
        public string UserId { get; set; }
        
        [MaxLength(100)]
        public string UserName { get; set; }
        
        [MaxLength(50)]
        public string IpAddress { get; set; }
        
        public string OldValues { get; set; } // JSON
        
        public string NewValues { get; set; } // JSON
        
        public DateTime CreatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("UserId")]
        public virtual AppUser User { get; set; }
    }
}
