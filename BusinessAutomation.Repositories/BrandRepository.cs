using BusinessAutomation.Database;
using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Repositories
{
    public class BrandRepository: BaseRepository<Brand>
    {
        BusinessAutomationDbContext db;
        public BrandRepository(BusinessAutomationDbContext db):base(db)
        {
            this.db = db;
          
        }

        public BusinessAutomationDbContext Db
        {
            get
            {
                return db;
            }
            set
            {
                db = value;
            }
        }

        public Brand GetById(int id)
        {
            var existingBrand = db.Brands.FirstOrDefault(c => c.Id == id);

            return existingBrand;
        }
        public async Task<IEnumerable<Brand>> GetAlll()
        {
            var brands = await db.Brands.ToListAsync();
            return brands;
        }
        public async Task<Brand> Create(Brand brand)
        {
            var obj = await db.Brands.AddAsync(brand);
            db.SaveChanges();
            return obj.Entity;
        }
        public void Delete(Brand brand)
        {
            db.Remove(brand);
            db.SaveChanges();
        }
        public override bool Update(Brand brand)
        {
            db.Brands.Update(brand);
            return db.SaveChanges() > 0;
        }


    }
}
