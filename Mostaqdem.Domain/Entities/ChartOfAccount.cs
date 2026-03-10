using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class ChartOfAccount
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string AccountCode { get; set; } // رقم الحساب
        
        [Required]
        [MaxLength(200)]
        public string AccountNameAr { get; set; }
        
        [MaxLength(200)]
        public string AccountNameEn { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string AccountType { get; set; } // (أصول/خصوم/حقوق ملكية/إيرادات/مصروفات)
        
        public int? ParentAccountId { get; set; } // للحسابات الرئيسية والفرعية
        
        public int Level { get; set; } // مستوى الحساب
        
        public bool IsActive { get; set; } = true;
        
        public bool AllowPosting { get; set; } = true; // السماح بالترحيل
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal OpeningBalance { get; set; } // الرصيد الافتتاحي
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal CurrentBalance { get; set; } // الرصيد الحالي
        
        [MaxLength(500)]
        public string Description { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("ParentAccountId")]
        public virtual ChartOfAccount ParentAccount { get; set; }
        
        public virtual ICollection<ChartOfAccount> SubAccounts { get; set; }
        public virtual ICollection<AccountingEntryLine> AccountingEntryLines { get; set; }
    }
}
