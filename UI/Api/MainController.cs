using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Repository;
using Library.Models;
using Library.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Api
{
    [Route("api/Main")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IRepository _repository;
        public MainController(GTContext repoContext, IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Main
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TravelProvider>>> Get()
        {
            var travelProviders = await _repository.FindAll<TravelProvider>();
            //var otherPost = await _context.Post.Skip(page * pageSize).Take(pageSize).ToListAsync();
            return travelProviders;
        }

        // GET: api/Posts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TravelProvider>> Get(int id)
        {
            var travelProviders = await _repository.FindById<TravelProvider>(id);

            if (travelProviders == null)
            {
                return NotFound();
            }

            return travelProviders;
        }

        // PUT: api/Main/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, TravelProvider tp)
        {
            if (id != tp.Id)
            {
                return BadRequest();
            }

            await _repository.UpdateAsync<TravelProvider>(tp);

            return NoContent();
        }

        // POST: api/Posts
        [HttpPost]
        public async Task<ActionResult<TravelProvider>> Post(TravelProvider travelProviders)
        {
            await _repository.CreateAsync<TravelProvider>(travelProviders);
            return CreatedAtAction("Create", new { id = travelProviders.Id }, travelProviders);
        }

        // DELETE: api/Posts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TravelProvider>> Delete(int id)
        {
            var travelProviders = await _repository.FindById<TravelProvider>(id);

            if (travelProviders == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync<TravelProvider>(travelProviders);

            return travelProviders;
        }

    }
}