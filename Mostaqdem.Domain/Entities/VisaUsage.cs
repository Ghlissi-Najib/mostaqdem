using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class VisaUsage
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int CompanyVisaId { get; set; }
        
        public int? EmployeeId { get; set; }
        
        public int? CandidateId { get; set; }
        
        [MaxLength(100)]
        public string WorkerName { get; set; }
        
        public DateTime UsageDate { get; set; }
        
        [MaxLength(50)]
        public string Status { get; set; } // (مستخدمة/ملغاة)
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public DateTime CreatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("CompanyVisaId")]
        public virtual CompanyVisa CompanyVisa { get; set; }
        
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        
        [ForeignKey("CandidateId")]
        public virtual Candidate Candidate { get; set; }
    }
}
