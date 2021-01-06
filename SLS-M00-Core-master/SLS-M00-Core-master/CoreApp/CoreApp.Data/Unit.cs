using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data
{
    public class Unit
    {
        [Key]
        public Guid UnitId { get; set; }
        [Required]
        public ItemCategory ItemCategoryId { get; set; }
        [Required]
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
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