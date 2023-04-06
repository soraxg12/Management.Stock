using Management.Socket.Domain.Entities;
using Management.Socket.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Stock.Services.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public TEntity Add(TEntity obj)
        {
            _baseRepository.Insert(obj);

            return obj;
        }

        public void Delete(int id) => _baseRepository.Delete(id);

        public IList<TEntity> Get() => _baseRepository.Select();

        public TEntity GetById(int id) => _baseRepository.Select(id);

        public TEntity update(TEntity obj)
        {
            _baseRepository.Update(obj);

            return obj;
        }
    }
}
