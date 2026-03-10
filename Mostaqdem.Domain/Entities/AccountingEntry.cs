using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class AccountingEntry
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string EntryNumber { get; set; } // رقم القيد
        
        [Required]
        public DateTime EntryDate { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string EntryType { get; set; } // (يومي/افتتاحي/إقفال/تسوية)
        
        [MaxLength(500)]
        public string Description { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalDebit { get; set; } // إجمالي المدين
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalCredit { get; set; } // إجمالي الدائن
        
        [MaxLength(50)]
        public string Status { get; set; } // (مسودة/معتمد/ملغي)
        
        public int? ReferenceId { get; set; } // معرف مرجعي (فاتورة/دفعة)
        
        [MaxLength(50)]
        public string ReferenceType { get; set; } // (فاتورة/دفعة/مصروف/راتب)
        
        public string CreatedByUserId { get; set; }
        
        public string ApprovedByUserId { get; set; }
        
        public DateTime? ApprovedDate { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("CreatedByUserId")]
        public virtual AppUser CreatedByUser { get; set; }
        
        [ForeignKey("ApprovedByUserId")]
        public virtual AppUser ApprovedByUser { get; set; }
        
        public virtual ICollection<AccountingEntryLine> AccountingEntryLines { get; set; }
    }
}
