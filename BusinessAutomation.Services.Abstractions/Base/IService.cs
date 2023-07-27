using BusinessAutomation.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Services.Abstractions.Base
{
    public interface IService<T> where T:class
    {
        ICollection<T> GetAll();
        bool Add(T entity);
        bool Update(T product);
        public bool Remove(T product);
    }
}
