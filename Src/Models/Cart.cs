using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aduaba.Models
{
    public class Cart
    {
        [Key]
        public string Id { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        public int CustomerId { get; set; }



        public virtual IEnumerable<CartItem> CartItems { get; set; }
    }
}