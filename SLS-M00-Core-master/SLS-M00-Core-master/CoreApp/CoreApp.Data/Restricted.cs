using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data
{
    public class Restricted
    {
        [Key]
        public Guid RestrictedId { get; set; }
        public string DisplayValue { get; set; }
        public string RestrictLocation { get; set; }
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
