using Management.Socket.Domain.Entities;
using Management.Socket.Domain.Interfaces;
using Management.Stock.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Stock.Infra.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly ManagementContext _managementContext;

        public BaseRepository(ManagementContext managementContext)
        {
            _managementContext = managementContext;
        }

        public void Insert(TEntity obj)
        {
            _managementContext.Set<TEntity>().Add(obj);
            _managementContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _managementContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _managementContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _managementContext.Set<TEntity>().Remove(Select(id));
            _managementContext.SaveChanges();
        }

        public IList<TEntity> Select() =>
            _managementContext.Set<TEntity>().ToList();

        public TEntity Select(int id) =>
            _managementContext.Set<TEntity>().Find(id);

    }
}
