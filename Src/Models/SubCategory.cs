using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aduaba.Models
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string CategoryId { get; set; }


        public virtual IEnumerable<Product> Product { get; set; }
    }
}