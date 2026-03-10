using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class BankTransaction
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int BankAccountId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string TransactionNumber { get; set; }
        
        [Required]
        public DateTime TransactionDate { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string TransactionType { get; set; } // (إيداع/سحب/تحويل)
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal BalanceAfter { get; set; } // الرصيد بعد العملية
        
        [MaxLength(200)]
        public string Description { get; set; }
        
        [MaxLength(100)]
        public string ReferenceNumber { get; set; }
        
        public int? PaymentId { get; set; } // ربط بدفعة
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public DateTime CreatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("BankAccountId")]
        public virtual BankAccount BankAccount { get; set; }
        
        [ForeignKey("PaymentId")]
        public virtual Payment Payment { get; set; }
    }
}
