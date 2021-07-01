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

        


        [Required]
        public int Quantity { get; set; }

        public virtual Cart Cart { get; set; }

        
        public string CartId { get; set; }

       
    }
}
