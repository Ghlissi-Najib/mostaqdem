using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class EmployeeRequest
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string RequestNumber { get; set; }
        
        [Required]
        public int EmployeeId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string RequestType { get; set; } // (إجازة/سلفة/تعديل بيانات/شهادة/استقالة)
        
        [Required]
        [MaxLength(200)]
        public string Subject { get; set; }
        
        [MaxLength(1000)]
        public string Description { get; set; }
        
        public DateTime RequestDate { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Status { get; set; } // (قيد الانتظار/قيد المراجعة/موافق/مرفوض)
        
        [MaxLength(50)]
        public string Priority { get; set; } // (عادي/عاجل/طارئ)
        
        public DateTime? ReviewedDate { get; set; }
        
        public string ReviewedByUserId { get; set; }
        
        [MaxLength(1000)]
        public string ReviewNotes { get; set; }
        
        public string AttachmentPath { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        
        [ForeignKey("ReviewedByUserId")]
        public virtual AppUser ReviewedByUser { get; set; }
    }
}
