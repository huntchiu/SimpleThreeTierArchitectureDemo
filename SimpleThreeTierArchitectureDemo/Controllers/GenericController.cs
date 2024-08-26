using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleThreeTierArchitectureDemo.Services;

namespace SimpleThreeTierArchitectureDemo.Controllers
{
    public abstract class GenericController<TEntity> : ControllerBase where TEntity : class
    {
        private readonly GenericService<TEntity> service;

        public GenericController(GenericService<TEntity> service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TEntity>> Get()
        {
            var entities = service.GetAll();
            return Ok(entities);
        }

    }
}