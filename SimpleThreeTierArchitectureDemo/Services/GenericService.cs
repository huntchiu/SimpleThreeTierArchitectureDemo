using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleThreeTierArchitectureDemo.Repositories;

namespace SimpleThreeTierArchitectureDemo.Services
{
    public class GenericService<TEntity>
  where TEntity : class
    {
        private readonly GenericRepository<TEntity> repository;

        public GenericService(GenericRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }
    }
}