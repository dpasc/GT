using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data.MainRepository.Repositories;
using Library.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Staff.Controllers
{
   
    public class TravelProviderController : Controller
    {
        private readonly TravelProviderRepository _tpr;
        public TravelProviderController(TravelProviderRepository tpr)
        {
            _tpr = tpr;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _tpr.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
             return  View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TravelProvider travelProvider)
        {
            if(ModelState.IsValid)
            {
                await _tpr.Add(travelProvider);
                return RedirectToAction(nameof(Index));
            }
            return View(travelProvider);

        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var travelProvider = await _tpr.Get(id);
            if(travelProvider == null)
            {
                return NotFound();
            }
            return View(travelProvider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(TravelProvider travelProvider, int id)
        {
            if(id != travelProvider.Id)
            {
                return NotFound();
            }

            if(id == travelProvider.Id)
            {
                await _tpr.Update(travelProvider);
            }
            return RedirectToAction(nameof(Index));
        }




    }
}