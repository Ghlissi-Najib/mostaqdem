using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Allowance
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int EmployeeId { get; set; }
        
        [Required]
        public int AllowanceTypeId { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Frequency { get; set; } // (شهري/سنوي/مرة واحدة)
        
        public DateTime StartDate { get; set; }
        
        public DateTime? EndDate { get; set; }
        
        public bool IsActive { get; set; } = true;
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        
        [ForeignKey("AllowanceTypeId")]
        public virtual AllowanceType AllowanceType { get; set; }
    }
}
