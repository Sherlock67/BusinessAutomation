using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Models.UtilitiesModels.ProductSearch;
using BusinessAutomation.Services.Abstractions.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Services.Abstractions.Products
{
    public interface IProductService : IService<Product>
    {
      
        Product GetById(int id);
        ICollection<Product> SearchProduct(ProductSearchCriteria searchCriteria);
    }
}
