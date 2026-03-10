using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class EmployeeDocument
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int EmployeeId { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string DocumentName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string DocumentType { get; set; } // (هوية/جواز سفر/شهادة/عقد)
        
        [Required]
        public string FilePath { get; set; }
        
        [MaxLength(50)]
        public string FileExtension { get; set; }
        
        public long FileSize { get; set; }
        
        public DateTime? ExpiryDate { get; set; } // تاريخ الانتهاء
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
