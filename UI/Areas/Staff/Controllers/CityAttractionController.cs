using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data;
using Domain.Data.MainRepository.Repositories;
using Library.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace UI.Areas.Staff.Controllers
{
    [Area("Staff")]
    public class CityAttractionController : Controller
    {
        // private readonly GTContext _context;
        private readonly CityAttractionsRepository _car;

        public CityAttractionController(CityAttractionsRepository car)
        {
            _car = car;
        }


        //Get List of city attractions
        public async Task<IActionResult> Index()
        {

            return View(await _car.GetAll());
        }

        //Create methods
        [HttpGet]
        public ActionResult Create()
        {

            ViewData["CityId"] = new SelectList(_car.context.Cities.OrderBy(x => x.Name), "Id", "Name");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CityAttraction ca)
        {
            //For testing purposes
                await _car.Add(ca);
                return RedirectToAction("Index");

        }

        //Update
        [HttpGet]
        public  async Task<IActionResult> Update(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var ca = await _car.Get(id);
            if(ca == null)
            {
                return NotFound();
            }
            ViewData["CityId"] = new SelectList(_car.context.Cities.OrderBy(x => x.Name), "Id", "Name");
            return View(ca);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, CityAttraction ca)
        {
            if(id != ca.Id)
            {
                return NotFound();
            }

            if(ModelState.IsValid)
            {
                    await _car.Update(ca);            
            }
            return RedirectToAction(nameof(Index));

        }

    }
}