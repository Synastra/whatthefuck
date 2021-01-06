using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data 
{
    public class OperationItem
    {
        [Key]
        public int OperationItemId { get; set; }
        [Required]
        public Operation OperationId { get; set; }
        [Required]
        public Item ItemId { get; set; }
        [Required]
        public OperationItemStatus OperationItemStatusId { get; set; }
        [Required]
        public double Weight1 { get; set; }
        [Required]
        public double Weight2 { get; set; }
        public string Comment { get; set; }
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
