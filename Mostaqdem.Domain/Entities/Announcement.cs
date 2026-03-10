using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Announcement
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        
        [Required]
        public string Content { get; set; }
        
        [MaxLength(50)]
        public string Type { get; set; } // (عام/عاجل/معلومة/تحذير)
        
        [MaxLength(50)]
        public string Priority { get; set; } // (عادي/مهم/عاجل)
        
        public DateTime StartDate { get; set; }
        
        public DateTime? EndDate { get; set; }
        
        public bool IsPublished { get; set; } = true;
        
        public bool ShowOnHomePage { get; set; } = false;
        
        public bool RequireConfirmation { get; set; } = false;
        
        [MaxLength(50)]
        public string TargetAudience { get; set; } // (الكل/الموظفين/الإدارة)
        
        public int? DepartmentId { get; set; }
        
        public string AttachmentPath { get; set; }
        
        public string CreatedByUserId { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        
        [ForeignKey("CreatedByUserId")]
        public virtual AppUser CreatedByUser { get; set; }
    }
}
