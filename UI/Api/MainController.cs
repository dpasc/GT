using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Library.Models;
using Library.Models.Models;
using Domain.Repository;

namespace UI.Api
{
    [Route("api/Main")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly TravelProviderRepository _travelProviderRepository;

        public MainController(TravelProviderRepository travelProviderRepository)
        {
            _travelProviderRepository = travelProviderRepository;
        }

      

        [HttpGet]
        public IEnumerable<TravelProvider> Get()
        {
            return  _travelProviderRepository.GetAll();
   
        } 

        [HttpGet("{id}")]
        public TravelProvider Get(int id)
        {
            return _travelProviderRepository.GetById(id);
        }
        
    }
}
