using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Priority { get; set; } // (منخفضة/متوسطة/عالية/عاجلة)
        
        [Required]
        [MaxLength(50)]
        public string Status { get; set; } // (جديدة/قيد التنفيذ/معلقة/مكتملة/ملغاة)
        
        public DateTime? StartDate { get; set; }
        
        public DateTime? DueDate { get; set; }
        
        public DateTime? CompletedDate { get; set; }
        
        public int? AssignedToEmployeeId { get; set; }
        
        public int? AssignedToDepartmentId { get; set; }
        
        public int ProgressPercentage { get; set; } = 0;
        
        public int? ParentTaskId { get; set; } // للمهام الفرعية
        
        [MaxLength(500)]
        public string AttachmentPaths { get; set; } // JSON array
        
        public string CreatedByUserId { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("AssignedToEmployeeId")]
        public virtual Employee AssignedToEmployee { get; set; }
        
        [ForeignKey("AssignedToDepartmentId")]
        public virtual Department AssignedToDepartment { get; set; }
        
        [ForeignKey("ParentTaskId")]
        public virtual Task ParentTask { get; set; }
        
        [ForeignKey("CreatedByUserId")]
        public virtual AppUser CreatedByUser { get; set; }
    }
}
