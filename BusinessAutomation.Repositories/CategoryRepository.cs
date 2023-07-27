using BusinessAutomation.Database;
using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Repositories.Abstractions.Categories;
using BusinessAutomation.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Repositories
{
    public class CategoryRepository: BaseRepository<Category>, ICategoryRepository
    {
        BusinessAutomationDbContext _db; 
        public CategoryRepository(BusinessAutomationDbContext db):base(db)
        {
            
        }
    }
}
