using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Leave
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string LeaveNumber { get; set; }
        
        [Required]
        public int EmployeeId { get; set; }
        
        [Required]
        public int LeaveTypeId { get; set; }
        
        [Required]
        public DateTime StartDate { get; set; }
        
        [Required]
        public DateTime EndDate { get; set; }
        
        public int TotalDays { get; set; }
        
        [MaxLength(1000)]
        public string Reason { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Status { get; set; } // (قيد المعالجة/موافق/مرفوض)
        
        public DateTime? ApprovedDate { get; set; }
        
        public string ApprovedByUserId { get; set; }
        
        [MaxLength(500)]
        public string RejectionReason { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        
        [ForeignKey("LeaveTypeId")]
        public virtual LeaveType LeaveType { get; set; }
        
        [ForeignKey("ApprovedByUserId")]
        public virtual AppUser ApprovedByUser { get; set; }
    }
}
