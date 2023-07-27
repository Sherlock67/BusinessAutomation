using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Repositories.Abstractions.Base;
using BusinessAutomation.Repositories.Base;
using BusinessAutomation.Services.Abstractions.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Services.Base
{
    public abstract class BaseService<T> : IService<T> where T : class
    {
        IRepository<T> _repository;

        public BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual bool Add(T entity)
        {
            return _repository.Add(entity);
        }

        public virtual ICollection<T> GetAll()
        {
            return _repository.GetAll();
        }

        

        public virtual bool Remove(T entity)
        {
            return  _repository.Remove(entity);
        }

        public virtual bool Update(T entity)
        {
            return _repository.Update(entity);
        }
    }
}
