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
    public class TravelPackageCityController : Controller
    {
        private readonly TravelPackageCityRepository _tpcr;

        public TravelPackageCityController(TravelPackageCityRepository tpcr)
        {
            _tpcr = tpcr;
        }


        public async  Task<IActionResult> Index(int id)
        {
            ViewBag.TravelPackage = _tpcr.context.TravelPackages
                .First(tp => tp.Id == id);
            return View(await _tpcr.GetAllInTP(id));
        }

        [HttpGet]
        public IActionResult Create(int tpId)
        {

            ViewBag.TravelPackage = _tpcr.context.TravelPackages
                .First(tp => tp.Id == tpId);
            ViewData["Cities"] = new SelectList(_tpcr.context.Cities
                .OrderBy(tpcr => tpcr.Name), "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TravelPackageCity travelPackageCity)
        {
            await _tpcr.Add(travelPackageCity);
            return RedirectToAction(nameof(Index));
        }



    }
}