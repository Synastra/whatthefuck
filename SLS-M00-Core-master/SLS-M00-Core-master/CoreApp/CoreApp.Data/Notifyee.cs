using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data
{
    public class Notifyee
    {
        [Key]
        public Guid NotifyeeId { get; set; }
        [Required]
        public Compartment CompartmentId { get; set; }
        [Required]
        public Role RoleId { get; set; }
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
