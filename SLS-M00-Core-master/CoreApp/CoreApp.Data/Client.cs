using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data 
{
   public class Client 
   {
       [Key]
       public Guid ClientId {get; set;}
       [Required]
       public User UserId {get; set;}
       [Required]
       public string CompanyName {get; set;}
       [Required]
       public string CompanyAddress {get; set;}
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
