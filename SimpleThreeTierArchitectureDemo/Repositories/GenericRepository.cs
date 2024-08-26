using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleThreeTierArchitectureDemo.Data;

namespace SimpleThreeTierArchitectureDemo.Repositories
{

    public class GenericRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext Context;

        public GenericRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public TEntity? GetById(Guid id)
        {
            return Context.Set<TEntity>().Find(id);
        }


        public void Create(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }

    }
}