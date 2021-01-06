using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data 
{
    public class Incident
    {
        [Key]
        public Guid IncidentId{ get; set;}
        [Required]
        public IncidentType IncidentTypeId{ get; set;}
        [Required]
        public Operation OperationId{ get; set;}
        [Required]
        public bool IsActive{ get; set;}
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
