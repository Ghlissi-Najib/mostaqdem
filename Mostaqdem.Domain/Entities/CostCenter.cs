using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mostaqdem.Domain.Entities
{
    public class CostCenter
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Code { get; set; } // رمز مركز التكلفة
        
        [Required]
        [MaxLength(100)]
        public string NameAr { get; set; }
        
        [MaxLength(100)]
        public string NameEn { get; set; }
        
        [MaxLength(500)]
        public string Description { get; set; }
        
        public bool IsActive { get; set; } = true;
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation Properties
        public virtual ICollection<AccountingEntryLine> AccountingEntryLines { get; set; }
    }
}
