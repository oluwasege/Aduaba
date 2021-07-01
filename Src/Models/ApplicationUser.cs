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
        public virtual IEnumerable<Card> Cards { get; set; }
        public virtual IEnumerable<Cart> Cart { get; set; }
        public virtual IEnumerable<CartItem> CartItems { get; set; }
      
    }
}