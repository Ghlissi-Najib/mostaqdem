using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        
        [Required]
        [MaxLength(1000)]
        public string Message { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Type { get; set; } // (تأخير/غياب/إجازة/عقد/تأشيرة)
        
        public string UserId { get; set; } // إذا كان للمستخدم محدد
        
        public int? EmployeeId { get; set; } // إذا كان متعلق بموظف
        
        public bool IsRead { get; set; } = false;
        
        public DateTime CreatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("UserId")]
        public virtual AppUser User { get; set; }
        
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
