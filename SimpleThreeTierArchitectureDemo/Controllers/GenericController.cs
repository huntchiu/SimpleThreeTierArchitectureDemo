using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimpleThreeTierArchitectureDemo.Models.Entities;
using SimpleThreeTierArchitectureDemo.Services;

namespace SimpleThreeTierArchitectureDemo.Controllers
{
    public abstract class GenericController<TEntity, TDto, TRequest, TResponse> : ControllerBase
    where TEntity : BaseEntity
    where TDto : class
    where TRequest : class
    where TResponse : class
    {
        private readonly GenericService<TEntity, TDto> service;
        private readonly IMapper mapper;
        public GenericController(GenericService<TEntity, TDto> service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TResponse>> Get()
        {
            var entities = service.GetAll();
            var response = mapper.Map<IEnumerable<TResponse>>(entities);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public ActionResult<TResponse> GetById(Guid id)
        {
            var entity = service.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            var response = mapper.Map<TResponse>(entity);
            return Ok(response);
        }

        [HttpPost]
        public ActionResult<TResponse> Create([FromBody] TRequest request)
        {
            var entityDto = mapper.Map<TDto>(request);
            var createdEntity = service.Create(entityDto);
            
            var createdEntityDto = mapper.Map<TDto>(createdEntity);
            var response = mapper.Map<TResponse>(createdEntityDto);
            return CreatedAtAction(nameof(GetById), new { id = createdEntity.Id }, response);
        }
        
        
    }
}