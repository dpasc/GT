using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data.MainRepository.Repositories;
using Library.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController:MainController<Customer, PersonRepository>
    {
        public CustomerController(PersonRepository repository) : base(repository)
        {

        }


        [HttpGet("Customer")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomer()
        {
            return await repository.GetAll();
        }



    }
}