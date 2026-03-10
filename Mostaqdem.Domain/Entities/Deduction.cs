using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Deduction
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int EmployeeId { get; set; }
        
        [Required]
        public int DeductionTypeId { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Frequency { get; set; } // (شهري/مرة واحدة)
        
        public DateTime Date { get; set; }
        
        [MaxLength(500)]
        public string Reason { get; set; }
        
        public bool IsActive { get; set; } = true;
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        
        [ForeignKey("DeductionTypeId")]
        public virtual DeductionType DeductionType { get; set; }
    }
}
