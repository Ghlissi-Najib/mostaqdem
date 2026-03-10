using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string EmployeeCode { get; set; } // رقم الموظف
        
        [MaxLength(50)]
        public string NationalId { get; set; } // رقم الهوية
        
        [MaxLength(50)]
        public string TaxNumber { get; set; } // رقم الضريبي
        
        public DateTime? DateOfBirth { get; set; }
        
        [Required]
        [MaxLength(10)]
        public string Gender { get; set; } // الجنس
        
        [Required]
        [MaxLength(50)]
        public string Nationality { get; set; } // الجنسية
        
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        
        [MaxLength(100)]
        public string Email { get; set; }
        
        [MaxLength(500)]
        public string Address { get; set; }
        
        public string Photo { get; set; } // صورة الموظف
        
        public DateTime? HireDate { get; set; } // تاريخ التوظيف
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal BasicSalary { get; set; } // الراتب الأساسي
        
        public bool IsActive { get; set; } = true;
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys
        public int? DepartmentId { get; set; }
        public int? JobTitleId { get; set; }
        public int? AgencyId { get; set; } // الوكيل
        public string CreatedByUserId { get; set; }

        // Navigation Properties
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        
        [ForeignKey("JobTitleId")]
        public virtual JobTitle JobTitle { get; set; }
        
        [ForeignKey("AgencyId")]
        public virtual Agency Agency { get; set; }
        
        [ForeignKey("CreatedByUserId")]
        public virtual AppUser CreatedByUser { get; set; }
        
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Leave> Leaves { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual ICollection<Allowance> Allowances { get; set; }
        public virtual ICollection<Deduction> Deductions { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }
        public virtual ICollection<EmployeeDocument> EmployeeDocuments { get; set; }
        public virtual ICollection<VisaApplication> VisaApplications { get; set; }
    }
}
