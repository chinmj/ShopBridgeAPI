using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShopBridgeAPI.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your Full Name")]
        [MaxLength(50, ErrorMessage = "Full Name should be less than 50 characters")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Where will I ship? :( , please enter a valid address")]
        public string Address { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Mobile number is mandatory")]
        public long MobileNo { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}