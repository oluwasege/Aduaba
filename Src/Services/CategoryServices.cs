using Aduaba.Data;
using Aduaba.DTO.Product;
using Aduaba.DTOPresentation.Product;
using Aduaba.Models;
using Aduaba.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba.Services
{
    public class CategoryServices:ICategoryServices
    {
        private readonly ApplicationDbContext _context;

        public CategoryServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public string AddCategory(AddCategoryRequest model)
        {
            var categoryExist = _context.Categories.FirstOrDefault(c => c.CategoryName == model.CategoryName);
            if (categoryExist != null)
            {
                return "Category already exist, Please check the name of the category";
            }
            _context.Categories.Add(new Category()
            {
                Id = Guid.NewGuid().ToString(),
                CategoryName = model.CategoryName
            });
            _context.SaveChanges();
            return "Category Added";
        }

        public List<ViewCategory> GetAllCategories()
        {
            List<ViewCategory> listOfCategories = new  List<ViewCategory>();
            List<Category>availableCategories = _context.Categories.ToList();
            foreach(var categories in availableCategories )
            {
                listOfCategories.Add(new ViewCategory() {
                
                    CategoryName=categories.CategoryName
                });

            }
            return listOfCategories;

            
        }
    }
}
