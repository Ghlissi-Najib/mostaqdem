using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string ExpenseNumber { get; set; } // رقم المصروف
        
        [Required]
        public int ExpenseCategoryId { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        
        public DateTime ExpenseDate { get; set; }
        
        [MaxLength(50)]
        public string PaymentMethod { get; set; }
        
        [MaxLength(100)]
        public string Vendor { get; set; } // المورد
        
        [MaxLength(100)]
        public string ReceiptNumber { get; set; } // رقم الإيصال
        
        public string ReceiptDocument { get; set; } // مسار الإيصال
        
        public int? ApprovedByUserId { get; set; }
        
        [MaxLength(50)]
        public string Status { get; set; } // (قيد الانتظار/موافق/مرفوض)
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public string CreatedByUserId { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("ExpenseCategoryId")]
        public virtual ExpenseCategory ExpenseCategory { get; set; }
        
        [ForeignKey("CreatedByUserId")]
        public virtual AppUser CreatedByUser { get; set; }
    }
}
