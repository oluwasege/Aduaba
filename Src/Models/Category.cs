using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba.Models
{
    public class Category
    {
        [Key]

        public string Id { get; set; }

        [Required]
        public string CategoryName { get; set; }


        public virtual IEnumerable<SubCategory> SubCategories { get; set; }
    }
}
