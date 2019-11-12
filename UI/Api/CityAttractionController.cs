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
    [Route("api/CityAttraction")]
    [ApiController]
    public class CityAttractionController : MainController<CityAttraction, CityAttractionsRepository>
    {
        public CityAttractionController(CityAttractionsRepository repository):base(repository)
        {

        }

        //// GET: api/Test/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return id.ToString();
        //}



    }
}