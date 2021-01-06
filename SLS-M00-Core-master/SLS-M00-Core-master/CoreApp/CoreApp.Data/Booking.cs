using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data 
{
   public class Booking
   {
        [Key]
        public Guid BookingId {get; set;}
        [Required]
        public DateTime CompletionDate {get; set;}
        [Required]
        public Consignee ConsigneeId {get; set;}
        [Required]
        public Client ClientId {get; set;}
        [Required]
        public Shipper ShipperId { get; set; }
        [Required]
        public bool IsActive {get; set;}
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    } 
}
