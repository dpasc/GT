using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data;
using Domain.Repository;
using Library.Models;
using Library.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace UI.Api
{
    [Route("api/Attractions")]
    [ApiController]
    public class AttractionsController : MainController<CityAttraction, CityAttractionRepository>
    {
    

        public AttractionsController(CityAttractionRepository repo) :base(repo)
        {

          
        }



    }

}