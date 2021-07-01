using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aduaba.Models
{
    public class ShippingAddress
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string ContactPersonsName { get; set; }

        [Required]
        public string Address { get; set; }

        public string City { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string AlternatePhoneNumber { get; set; }

        public string Landmark { get; set; }

        public virtual ApplicationUser  ApplicationUser { get; set; }

        [Required]
        public int ApplicationUserId { get; set; }


        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
