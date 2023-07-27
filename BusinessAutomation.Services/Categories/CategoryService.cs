using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Repositories.Abstractions.Base;
using BusinessAutomation.Repositories.Abstractions.Categories;
using BusinessAutomation.Services.Abstractions.Categories;
using BusinessAutomation.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Services.Categories
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        ICategoryRepository _categoryRepository; 
        public CategoryService(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }
    }
}
