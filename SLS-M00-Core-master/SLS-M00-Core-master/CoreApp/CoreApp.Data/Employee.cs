using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data
{
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }
        [Required]
        public User UserId { get; set; }
        [Required]
        public Department DepartmentId { get; set; }
        [Required]
        public string PassNum { get; set; }
        [Required]
        public string PinNum { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
