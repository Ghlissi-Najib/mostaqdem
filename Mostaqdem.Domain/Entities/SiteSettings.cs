using System;
using System.ComponentModel.DataAnnotations;

namespace Mostaqdem.Domain.Entities
{
    public class SiteSettings
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(200)]
        public string SiteNameAr { get; set; }
        
        [MaxLength(200)]
        public string SiteNameEn { get; set; }
        
        public string LogoUrl { get; set; }
        
        public string FaviconUrl { get; set; }
        
        [MaxLength(100)]
        public string PrimaryEmail { get; set; }
        
        [MaxLength(20)]
        public string PrimaryPhone { get; set; }
        
        [MaxLength(500)]
        public string AddressAr { get; set; }
        
        [MaxLength(500)]
        public string AddressEn { get; set; }
        
        public string AboutUsAr { get; set; }
        
        public string AboutUsEn { get; set; }
        
        [MaxLength(500)]
        public string MetaDescriptionAr { get; set; }
        
        [MaxLength(500)]
        public string MetaDescriptionEn { get; set; }
        
        [MaxLength(200)]
        public string MetaKeywords { get; set; }
        
        [MaxLength(50)]
        public string DefaultLanguage { get; set; }
        
        [MaxLength(50)]
        public string Currency { get; set; }
        
        [MaxLength(50)]
        public string TimeZone { get; set; }
        
        public bool MaintenanceMode { get; set; } = false;
        
        public string MaintenanceMessage { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
