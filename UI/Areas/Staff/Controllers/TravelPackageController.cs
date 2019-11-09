using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data.MainRepository.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Staff.Controllers
{
    [Area("Staff")]
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


    }


}