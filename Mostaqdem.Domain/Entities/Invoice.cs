using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string InvoiceNumber { get; set; } // رقم الفاتورة
        
        [Required]
        [MaxLength(50)]
        public string InvoiceType { get; set; } // (مبيعات/مشتريات/خدمات)
        
        public DateTime InvoiceDate { get; set; }
        
        public DateTime? DueDate { get; set; }
        
        [MaxLength(200)]
        public string CustomerName { get; set; } // اسم العميل
        
        [MaxLength(100)]
        public string CustomerEmail { get; set; }
        
        [MaxLength(20)]
        public string CustomerPhone { get; set; }
        
        [MaxLength(500)]
        public string CustomerAddress { get; set; }
        
        [MaxLength(50)]
        public string TaxNumber { get; set; } // الرقم الضريبي
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal SubTotal { get; set; } // المجموع الفرعي
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal TaxAmount { get; set; } // قيمة الضريبة
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal DiscountAmount { get; set; } // قيمة الخصم
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; } // المجموع الكلي
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal PaidAmount { get; set; } // المبلغ المدفوع
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal RemainingAmount { get; set; } // المبلغ المتبقي
        
        [Required]
        [MaxLength(50)]
        public string PaymentStatus { get; set; } // (مدفوعة/جزئية/غير مدفوعة)
        
        [MaxLength(50)]
        public string PaymentMethod { get; set; } // (نقدي/تحويل/شيك/بطاقة)
        
        [MaxLength(1000)]
        public string Notes { get; set; }
        
        public string CreatedByUserId { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("CreatedByUserId")]
        public virtual AppUser CreatedByUser { get; set; }
        
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
