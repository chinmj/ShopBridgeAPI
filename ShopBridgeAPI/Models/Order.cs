using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ShopBridgeAPI.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Amount cannot be blank!")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "Where shall I ship sir ?")]
        public string ShippingAddress { get; set; }
        [Required(ErrorMessage = "Please enter the Email address")]
        public string Email { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Status { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Customer Customer { get; set; }
    }
}