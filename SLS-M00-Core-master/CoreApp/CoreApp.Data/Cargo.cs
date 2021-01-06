using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data
{
    public class Cargo
    {
        [Key]
        public Guid CargoId { get; set; }
        [Required]
        public CargoDetail CargoDetailId { get; set; }
        [Required]
        public Measurement MeasurementId { get; set; }
        [Required]
        public PackagingType PackagingTypeId { get; set; }
        [Required]
        public Location LocationId { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
