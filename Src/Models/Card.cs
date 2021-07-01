using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba.Models
{
    public class Card
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string CardHolderName { get; set; }

        [Required]
        public string CardNumber { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }

        [Required]
        [MaxLength(3)]
        public string CCV { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        public int CustomerId { get; set; }
    }
}
