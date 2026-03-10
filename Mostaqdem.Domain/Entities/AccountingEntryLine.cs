using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class AccountingEntryLine
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int AccountingEntryId { get; set; }
        
        [Required]
        public int ChartOfAccountId { get; set; }
        
        [MaxLength(500)]
        public string Description { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal DebitAmount { get; set; } // مدين
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal CreditAmount { get; set; } // دائن
        
        public int? CostCenterId { get; set; }
        
        public DateTime CreatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("AccountingEntryId")]
        public virtual AccountingEntry AccountingEntry { get; set; }
        
        [ForeignKey("ChartOfAccountId")]
        public virtual ChartOfAccount ChartOfAccount { get; set; }
        
        [ForeignKey("CostCenterId")]
        public virtual CostCenter CostCenter { get; set; }
    }
}
