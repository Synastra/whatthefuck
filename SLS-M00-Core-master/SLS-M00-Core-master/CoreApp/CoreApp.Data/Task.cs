using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data
{
    public class Task
    {
        [Key]
        public Guid TaskId { get; set; }
        [Required]
        public Booking BookingId { get; set; }
        [Required]
        public String TaskStatus { get; set; }
        [Required]
        public DateTime CompleteBy { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public String CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public String UpdatedBy { get; set; }

    }
}
