using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class VehicleDocument
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int VehicleId { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string DocumentName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string DocumentType { get; set; } // (رخصة/تأمين/استمارة/فحص دوري)
        
        [Required]
        public string FilePath { get; set; }
        
        [MaxLength(50)]
        public string FileExtension { get; set; }
        
        public long FileSize { get; set; }
        
        public DateTime? IssueDate { get; set; }
        
        public DateTime? ExpiryDate { get; set; }
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("VehicleId")]
        public virtual Vehicle Vehicle { get; set; }
    }
}
