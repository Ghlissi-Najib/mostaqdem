using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class InvoiceItem
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int InvoiceId { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Description { get; set; } // وصف الخدمة/المنتج
        
        public int Quantity { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; } // سعر الوحدة
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal TaxRate { get; set; } // نسبة الضريبة
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal TaxAmount { get; set; } // قيمة الضريبة
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal DiscountAmount { get; set; } // قيمة الخصم
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; } // المجموع
        
        public DateTime CreatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("InvoiceId")]
        public virtual Invoice Invoice { get; set; }
    }
}
