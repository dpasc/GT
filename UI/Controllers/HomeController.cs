using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data;
using Library.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GTContext _gTContext;

        public HomeController(ILogger<HomeController> logger, GTContext gTContext)
        {
            _logger = logger;
            _gTContext = gTContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Search(Search search)
        {
           
            if(!String.IsNullOrEmpty(search.TpNameQuery))
            {
                var travaelpackages = from tp in _gTContext.TravelPackages select tp;
                travaelpackages = travaelpackages.Where(tp => tp.Name.Contains(search.TpNameQuery));
                return View(travaelpackages);
            }
             else if(String.IsNullOrEmpty(search.TpNameQuery) && !String.IsNullOrEmpty(search.TpLocationQuery))
            {
               //ToDo Add this search
                var travelPackages = _gTContext.TravelPackages
                     .Include(tp => tp.Cities)
                     .ToList();
               
                return View(travelPackages);                               
            }
                return RedirectToAction("Index");
            



           
        }


    }
}
