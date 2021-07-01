using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aduaba.Models
{
    public class Order
    {
        [Key]
        public string OrderId { get; set; }

        [Required]
        public string OrderNumber { get; set; }

        public virtual OrderStatus OrderStatus { get; set; }

        [Required]
        public int OrderStatusId { get; set; }

        [Required]
        public string PaymentType { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        //public virtual ShippingAddress ShippingAddress { get; set; }


        //public string ShippingAddressId { get; set; }

       // public virtual BillingAddress BillingAddress { get; set; }


        //public string BillingAddressId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        public int CustomerId { get; set; }


        public virtual IEnumerable<CartItem> CartItems { get; set; }
    }
}