using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba.Models
{
    public class CartItem
    {
        [Key]
        public string CartItemId { get; set; }

        public virtual Product Product { get; set; }

        [Required]
        public string ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        public virtual Cart Cart { get; set; }

        [Required]
        public string CartId { get; set; }

        public virtual Order Order { get; set; }

        public string OrderId { get; set; }
    }
}
