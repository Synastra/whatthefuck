using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data
{
   public class Lot
    {
        [Key]
        public Guid LotId { get; set; }
        public string LotLocation { get; set; }
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
