
using System.Threading.Tasks;
using Domain.Data.MainRepository.Repositories;
using Library.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace UI.Areas.Staff.Controllers
{
    
    public class TravelPackageController : Controller
    {
        private readonly TravelPackageRepository _travelPackageRepository;

        public TravelPackageController(TravelPackageRepository travelPackageRepository)
        {
            _travelPackageRepository = travelPackageRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _travelPackageRepository.GetAll());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TravelPackage travelPackage)
        {
            if (ModelState.IsValid)
            {
                await _travelPackageRepository.Add(travelPackage);
                return RedirectToAction("Index");
            }
            return View(travelPackage);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var travelPackage = await _travelPackageRepository.Get(id);
            if(travelPackage == null)
            {
                return NotFound();
            }
            return View(travelPackage);

        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if( id == null)
            {
                return NotFound();
            }
            var travelPackage = await _travelPackageRepository.Get(id);
            if (travelPackage == null)
            {
                return NotFound();
            }
            return View(travelPackage);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TravelPackage travelPackage)
        {
            if(travelPackage == null)
            {
                return NotFound();
            }

            if(ModelState.IsValid)
            {
                try
                {
                    await _travelPackageRepository.Update(travelPackage);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (travelPackage == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                    return RedirectToAction("Index");
                }
                return View(travelPackage);
            }

        }
  }


