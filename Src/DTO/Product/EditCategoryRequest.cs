using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba.DTO.Product
{
    public class EditCategoryRequest
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string NewCategoryName { get; set; }
    }
}
