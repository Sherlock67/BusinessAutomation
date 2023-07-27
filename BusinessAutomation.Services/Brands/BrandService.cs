using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Repositories.Abstractions.Brands;
using BusinessAutomation.Services.Abstractions.Brands;
using BusinessAutomation.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Services.Brands
{
    public class BrandService : BaseService<Brand>, IBrandService
    {
        IBrandRepository _brandRepository;
        public BrandService(IBrandRepository brandRepository) : base(brandRepository)
        {
            this._brandRepository = brandRepository;
        }
        public bool Add(Brand entity)
        {
            //pre logic -- validation logic, or checking logic 

            var isSuccess = _brandRepository.Add(entity);

            //post processing


            return isSuccess;
        }
        public ICollection<Brand> GetAll()
        {
            return _brandRepository.GetAll();
        }
        public Brand GetById(int id)
        {
            return _brandRepository.GetById(id);
        }
        public bool Remove(Brand brand)
        {
            //pre logic 

            bool isSuccess = _brandRepository.Remove(brand);

            // post processing

            return isSuccess;

        }
        public bool Update(Brand brand)
        {
            return _brandRepository.Update(brand);
        }
    }
}
