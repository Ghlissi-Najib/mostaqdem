using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class BankAccount
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string BankName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string AccountNumber { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string IBAN { get; set; }
        
        [MaxLength(50)]
        public string AccountType { get; set; } // (جاري/توفير)
        
        [MaxLength(50)]
        public string Currency { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }
        
        [MaxLength(100)]
        public string BranchName { get; set; }
        
        [MaxLength(50)]
        public string SwiftCode { get; set; }
        
        public bool IsActive { get; set; } = true;
        
        public bool IsDefault { get; set; } = false;
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation Properties
        public virtual ICollection<BankTransaction> BankTransactions { get; set; }
    }
}
