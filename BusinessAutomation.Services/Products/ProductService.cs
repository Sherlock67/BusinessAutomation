using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Models.UtilitiesModels.ProductSearch;
using BusinessAutomation.Repositories;
using BusinessAutomation.Repositories.Abstractions.Products;
using BusinessAutomation.Services.Abstractions.Products;
using BusinessAutomation.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Services.Products
{
    public class ProductService : BaseService<Product>, IProductService
    {
        IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository):base(productRepository)
        {
            _productRepository = productRepository;
        }

        //public bool Add(Product entity)
        //{
        //    //pre logic -- validation logic, or checking logic 

        //    var isSuccess = _productRepository.Add(entity);

        //    //post processing


        //    return isSuccess;
        //}

        public ICollection<Product> GetAll()
        {
            //logic for get all 
            var products = _productRepository.GetAll();

            //post processing of data 

            return products; 
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public bool Remove(Product product)
        {
            //pre logic 

            bool isSuccess = _productRepository.Remove(product);

            // post processing

            return isSuccess;

        }

        public ICollection<Product> SearchProduct(ProductSearchCriteria searchCriteria)
        {
            return _productRepository.SearchProduct(searchCriteria);
        }

        public bool Update(Product product)
        {
            return _productRepository.Update(product);
        }
    }
}
