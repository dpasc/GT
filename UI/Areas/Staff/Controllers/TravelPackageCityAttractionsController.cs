using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data.MainRepository.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Staff.Controllers
{
    [Area("Staff")]
    public class TravelPackageCityAttractionsController : Controller
    {
        private readonly TravelPackageCityAttractionsRepository _tpcar;

        public TravelPackageCityAttractionsController(TravelPackageCityAttractionsRepository tpcar)
        {
            _tpcar = tpcar;
        }


    
        public async Task<IActionResult> Index(int id)
        {
            return View(await _tpcar.GetListForTPC(id));
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            return View(id);
        }



    }
}