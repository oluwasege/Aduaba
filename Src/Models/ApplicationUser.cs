using Aduaba.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Aduaba.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; }
        public string AvatarUrl { get; set; }
        public virtual IEnumerable<BillingAddress> BillingAddresses { get; set; }
        public virtual IEnumerable<ShippingAddress> ShippingAddresses { get; set; }
        public virtual IEnumerable<Card> Cards { get; set; }
        public virtual IEnumerable<Cart> Cart { get; set; }
        public virtual IEnumerable<CartItem> CartItems { get; set; }
        public virtual IEnumerable<WishList> Wishlist { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }
        public virtual IEnumerable<PaymentHistory> PaymentHistories { get; set; }
    }
}