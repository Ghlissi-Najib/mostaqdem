using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mostaqdem.Domain.Entities
{
    public class VehicleMaintenance
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int VehicleId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string MaintenanceType { get; set; } // (دورية/إصلاح/طارئة)
        
        [MaxLength(500)]
        public string Description { get; set; }
        
        public DateTime MaintenanceDate { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Cost { get; set; }
        
        [MaxLength(100)]
        public string ServiceProvider { get; set; } // مزود الخدمة
        
        public int? MileageAtMaintenance { get; set; }
        
        public DateTime? NextMaintenanceDate { get; set; }
        
        [MaxLength(50)]
        public string Status { get; set; } // (مجدولة/قيد التنفيذ/مكتملة)
        
        [MaxLength(500)]
        public string Notes { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Keys & Navigation
        [ForeignKey("VehicleId")]
        public virtual Vehicle Vehicle { get; set; }
    }
}
