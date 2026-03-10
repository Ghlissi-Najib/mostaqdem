using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mostaqdem.Domain.Entities
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string NameAr { get; set; }
        
        [MaxLength(100)]
        public string NameEn { get; set; }
        
        public int MaxDaysPerYear { get; set; } // الحد الأقصى للأيام
        
        public bool IsPaid { get; set; } // مدفوعة أم لا
        
        public bool RequiresApproval { get; set; } // تحتاج موافقة
        
        public bool IsActive { get; set; } = true;
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation Properties
        public virtual ICollection<Leave> Leaves { get; set; }
    }
}
