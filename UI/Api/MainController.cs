using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data;
using Domain.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Api
{
    [Route("api/[Main]")]
    [ApiController]
    public abstract class MainController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository _repository;

        public MainController(TRepository repository) 
        {
            this._repository = repository;
        }


        //Get:api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
                return await _repository.GetAll();

        }

        //Get by Id
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>>Get(int id)
        {
            var entity = await _repository.Get(id);
            if(entity == null)
            {
                return NotFound();
            }

            return entity;
        }



    }

  }