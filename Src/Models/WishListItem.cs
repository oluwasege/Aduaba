using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba.Models
{
    public class WishListItem
    {
        [Key]
        public string WishListItemId { get; set; }

        public virtual Product Product { get; set; }

        [Required]
        public string ProductId { get; set; }

        public virtual WishList WishList { get; set; }

        [Required]
        public string WishListId { get; set; }
    }
}
