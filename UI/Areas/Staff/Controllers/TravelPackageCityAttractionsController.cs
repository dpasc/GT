using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data.MainRepository.Repositories;
using Library.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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

            ViewBag.TravelPackageCity = _tpcar.context.TravelPackageCities
               .First(tp => tp.Id == id);
            return View(await _tpcar.GetListForTPC(id));
        }

        [HttpGet]
        public async  Task<IActionResult> Create(int tpcId)
        {
            var caList = await  _tpcar.GetListForOfCAForIndex(tpcId);

            ViewBag.TravelPackageCity = _tpcar.context.TravelPackageCities
            .First(tp => tp.Id == tpcId);
            ViewData["CityAttractions"] = new SelectList(caList, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TravelPackageCityAttraction travelPackageCityAttraction)
        {
            await  _tpcar.Add(travelPackageCityAttraction);
            return RedirectToAction(nameof(Index), new { Id = travelPackageCityAttraction.TravelPackageCityId });
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            var travelPackageCityAttraction = await _tpcar.Get(id);
            if(travelPackageCityAttraction == null)
            {
                return NotFound();
            }

            //  var caList = await _tpcar.GetListForOfCAForIndex(id);
            var caList = await _tpcar.context.CityAttractions
                .Where(ca => ca.CityId == travelPackageCityAttraction.TravelPackageCity.CityId)
                .ToListAsync();


            ViewData["CityAttractions"] = new SelectList(caList, "Id", "Name");
            return View(travelPackageCityAttraction);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TravelPackageCityAttraction travelPackageCityAttraction)
        {
            if(id != travelPackageCityAttraction.Id)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                await _tpcar.Update(travelPackageCityAttraction);
                return RedirectToAction(nameof(Index), new { Id = travelPackageCityAttraction.TravelPackageCityId });
            }
            return View(travelPackageCityAttraction);
        }

    }
}