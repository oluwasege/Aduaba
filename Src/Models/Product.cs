using System;
using System.ComponentModel.DataAnnotations;

namespace Aduaba.Models
{
    public class Product
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        public virtual Category Category { get; set; }

        [Required]
        public string CategoryId { get; set; }

        public string SubCategory { get; set; }

        

        [Required]
        public int VendorId { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        public string ImageUrl { get; set; }
    }
}