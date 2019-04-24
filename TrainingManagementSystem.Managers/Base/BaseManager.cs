using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagementSystem.Repositories.Base;
using TrainingManagementSystem.Repositories.Contracts;

namespace TrainingManagementSystem.Managers.Base
{
    public abstract class BaseManager<T> where T:class
    {
        private IRepository<T> _repository;

        public BaseManager(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual bool Add(T entity)
        {
            return _repository.Add(entity);
        }
        public virtual bool Update(T entity)
        {
            return _repository.Update(entity);
        }
        public virtual bool Remove(T entity)
        {
            return _repository.Remove(entity);
        }
        public virtual T GetById (int id)
        {
            return _repository.GetById(id);
        }

        public virtual ICollection<T> GetAll()
        {
            return _repository.GetAll();
        }

    }
}
