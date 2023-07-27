using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Models.UtilitiesModels.ProductSearch;
using BusinessAutomation.Repositories.Abstractions.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Repositories.Abstractions.Products
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetById(int id);
        ICollection<Product> SearchProduct(ProductSearchCriteria searchCriteria);
    }
}
