using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CyberShoppeeDataAccessLayer.CyberShoppeeContext;
using CyberShoppeeDataAccessLayer.Entity;

namespace CyberShoppeeApi.CyberShoppeeRepository.CategoriesRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        CyberShoppeeContext context = new CyberShoppeeContext();

        public IEnumerable<Category> GetAllCategories()
        {
            var categories = context.Categories.ToList();
            if (categories == null) { 
            throw new CategoriesDataUnavailableException("No Categories Found");
            }
            return categories;
        }


        public Category GetCategoryById(int id)
        {
            var category = context.Categories.Find(id);
            if (category == null)
            {
                throw new CategoriesDataUnavailableException("No Categories Found");
            }
            return category;
        }


    }
}