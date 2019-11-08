using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data.MainRepository.Repositories;
using Microsoft.AspNetCore.Mvc;

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



        public async  Task<IActionResult> Index()
        {
            return View(await _tpcr.GetAll());
        }
    }
}