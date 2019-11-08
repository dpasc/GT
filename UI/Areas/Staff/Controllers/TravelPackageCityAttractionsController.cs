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
        private readonly TravelPackageCityRepository _tpcar;

        public TravelPackageCityAttractionsController(TravelPackageCityRepository tpcar)
        {
            _tpcar = tpcar;
        }



        public IActionResult Index()
        {
            return View( _tpcar.GetAll());
        }



    }
}