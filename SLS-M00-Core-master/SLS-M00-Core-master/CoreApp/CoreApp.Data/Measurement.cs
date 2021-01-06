using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data
{
    public class Measurement
    {
        [Key]
        public Guid MeasurementId { get; set; }
        public bool IsMeasured { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Volume { get; set; }
        public byte[] MeasurementImage { get; set; }
        public DateTime MeasurementTime { get; set; }
        [Required]
        public Platform PlatformId { get; set; }
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
