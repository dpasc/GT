using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Staff.Controllers
{
    [Area("Staff")]
    public class TravelPackageCitiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}