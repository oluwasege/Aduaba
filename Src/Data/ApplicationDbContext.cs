using Aduaba.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba.Data
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //public DbSet<BillingAddress> BillingAddresses { get; set; }
        //public DbSet<ShippingAddress> ShippingAddresses { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<PaymentHistory> PaymentHistories { get; set; }
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<Promotion> Promotions { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
       // public DbSet<Vendor> Vendors { get; set; }
        public DbSet<WishList> WishLists { get; set; }
        public DbSet<WishListItem> WishListItems { get; set; }
    }
}
