using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Repositories.Abstractions.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Repositories.Abstractions.Brands
{
    public interface IBrandRepository  : IRepository<Brand>
    {
        Brand GetById(int id);
    }
}
