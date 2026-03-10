using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string PlateNumber { get; set; } // رقم اللوحة
        
        [Required]
        [MaxLength(50)]
        public string VehicleType { get; set; } // نوع السيارة
        
        [MaxLength(50)]
        public string Brand { get; set; } // الماركة
        
        [MaxLength(50)]
        public string Model { get; set; } // الموديل
        
        public int? Year { get; set; } // سنة الصنع
        
        [MaxLength(50)]
        public string Color { get; set; }
        
        [MaxLength(50)]
        public string ChassisNumber { get; set; } // رقم الشاسيه
        
        public int? AssignedDriverId { get; set; } // السائق المعين
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal? PurchasePrice { get; set; } // سعر الشراء
        
        public DateTime? PurchaseDate { get; set; }
        
        public DateTime? RegistrationExpiryDate { get; set; } // تاريخ انتهاء التسجيل
        
        public DateTime? InsuranceExpiryDate { get; set; } // تاريخ انتهاء التأمين
        
        public int? Mileage { get; set; } // عداد الكيلومترات
        
        [MaxLength(50)]
        public string FuelType { get; set; } // نوع الوقود
        
        [MaxLength(50)]
        public string Status { get; set; } // (متاحة/مستخدمة/صيانة/خارج الخدمة)
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public bool IsActive { get; set; } = true;
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("AssignedDriverId")]
        public virtual Employee AssignedDriver { get; set; }
        
        public virtual ICollection<VehicleMaintenance> VehicleMaintenances { get; set; }
        public virtual ICollection<VehicleDocument> VehicleDocuments { get; set; }
    }
}
