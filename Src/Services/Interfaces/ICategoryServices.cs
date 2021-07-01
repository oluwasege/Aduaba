using Aduaba.DTO.Product;
using Aduaba.DTOPresentation.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba.Services.Interfaces
{
   public  interface ICategoryServices
    {
        public string AddCategory(AddCategoryRequest model);
        public List<ViewCategory> GetAllCategories();
    }
}
