using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class PerformanceReview
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int EmployeeId { get; set; }
        
        [Required]
        public DateTime ReviewDate { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string ReviewPeriod { get; set; } // (ربع سنوي/نصف سنوي/سنوي)
        
        public int? ReviewerUserId { get; set; }
        
        public int PerformanceScore { get; set; } // (1-100)
        
        [MaxLength(50)]
        public string PerformanceRating { get; set; } // (ممتاز/جيد جدا/جيد/مقبول/ضعيف)
        
        [MaxLength(2000)]
        public string Strengths { get; set; } // نقاط القوة
        
        [MaxLength(2000)]
        public string Weaknesses { get; set; } // نقاط الضعف
        
        [MaxLength(2000)]
        public string ImprovementAreas { get; set; } // مجالات التحسين
        
        [MaxLength(2000)]
        public string Goals { get; set; } // الأهداف
        
        [MaxLength(2000)]
        public string EmployeeComments { get; set; } // تعليقات الموظف
        
        [MaxLength(2000)]
        public string ReviewerComments { get; set; } // تعليقات المقيم
        
        [MaxLength(50)]
        public string Status { get; set; } // (مسودة/مكتمل/موقع)
        
        public DateTime? EmployeeSignedDate { get; set; }
        
        public DateTime? ReviewerSignedDate { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
