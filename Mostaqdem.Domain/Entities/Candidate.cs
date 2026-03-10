using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Candidate
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        
        [MaxLength(100)]
        public string Email { get; set; }
        
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        
        [MaxLength(50)]
        public string Nationality { get; set; }
        
        public DateTime? DateOfBirth { get; set; }
        
        [MaxLength(10)]
        public string Gender { get; set; }
        
        [MaxLength(500)]
        public string Address { get; set; }
        
        public string CV { get; set; } // CV file path
        
        public string Photo { get; set; }
        
        public int? AppliedJobTitleId { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal? ExpectedSalary { get; set; }
        
        public int? YearsOfExperience { get; set; }
        
        [MaxLength(200)]
        public string Education { get; set; }
        
        [MaxLength(1000)]
        public string Skills { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Status { get; set; } // (جديد/قيد المراجعة/مقابلة/مقبول/مرفوض)
        
        public DateTime? InterviewDate { get; set; }
        
        [MaxLength(1000)]
        public string InterviewNotes { get; set; }
        
        [MaxLength(500)]
        public string RejectionReason { get; set; }
        
        public DateTime ApplicationDate { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("AppliedJobTitleId")]
        public virtual JobTitle AppliedJobTitle { get; set; }
        
        public virtual ICollection<CandidateDocument> CandidateDocuments { get; set; }
    }
}
