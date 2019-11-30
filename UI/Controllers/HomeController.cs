using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data;
using Domain.Data.MainRepository.Repositories;
using Library.Models.Models;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<IdentityUser> _userManager;
        private readonly TravelPackageRepository _tpr;



        public HomeController(ILogger<HomeController> logger, GTContext gTContext, UserManager<IdentityUser> userManager,TravelPackageRepository tpr)
        {
            _logger = logger;
            _gTContext = gTContext;
            _userManager = userManager;
            _tpr = tpr;
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
             //ToDo: Clean Search Method        
            if(!String.IsNullOrEmpty(search.TpNameQuery))
            {
                var travaelpackages = from tp in _gTContext.TravelPackages select tp;
                travaelpackages = travaelpackages.Where(tp => tp.Name.Contains(search.TpNameQuery));
                return View(travaelpackages);
            }
            else if (String.IsNullOrEmpty(search.TpNameQuery) && !String.IsNullOrEmpty(search.TpLocationQuery))
            {
                var travelPackages = _tpr.GetAllViaLocationMVC(search.TpLocationQuery);                     
                return View(travelPackages);
            }
            return RedirectToAction("Index");
           
        }


    }
}
