using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba.DTO.Product
{
    public class AddCategoryRequest
    {
        [Required]
        public string CategoryName { get; set; }
    }
}
