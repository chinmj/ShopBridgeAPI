using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShopBridgeAPI.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter product name")]
        [MaxLength(50,ErrorMessage = "Name should be less than 50 characters")]
        public string Name { get; set; }
        [MaxLength(500,ErrorMessage = "Description should be less than 500 characters")]
        public string Description { get; set; }
        [Required(ErrorMessage = "May I know how much stock is left ?")]
        public int Stock { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}