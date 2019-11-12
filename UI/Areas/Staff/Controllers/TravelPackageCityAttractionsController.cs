using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data.MainRepository.Repositories;
using Library.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UI.Areas.Staff.Controllers
{
    [Area("Staff")]
    public class TravelPackageCityAttractionsController : Controller
    {
        private readonly TravelPackageCityAttractionsRepository _tpcar;
        private readonly TravelPackageCityRepository _tpcr;
        private readonly CityAttractionsRepository _ca;

        public TravelPackageCityAttractionsController(TravelPackageCityAttractionsRepository tpcar, TravelPackageCityRepository tpcr, CityAttractionsRepository ca)
        {
            _tpcar = tpcar;
            _tpcr = tpcr;
            _ca = ca;
        }
    
        public async Task<IActionResult> Index(int id)
        {
            
            return View(await _tpcar.GetListForTPC(id));

        }

        [HttpGet]
        public async  Task<IActionResult> Create(int id)
        {
            var tpca = new TravelPackageCityAttraction();
            tpca.TravelPackageCityId = id;
     

            var caList = await  _tpcar.GetListForOfCAForIndex(id);

            ViewData["CityAttractions"] = new SelectList(caList, "Id", "Name");

            return View(tpca);
        }



    }
}